﻿using ChromePasswordRevealer.Data.DataContext.Abstract;
using ChromePasswordRevealer.Data.Encryption;
using ChromePasswordRevealer.Data.Encryption.Abstract;
using ChromePasswordRevealer.Data.Extensions;
using ChromePasswordRevealer.Data.Models;
using ChromePasswordRevealer.Data.Repoistories.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ChromePasswordRevealer.Data.Repoistories
{
    public class UserDataRepository : IUserDataRepository
    {
        private const string SELECT_ALL_QUERY = "SELECT action_url, username_value, password_value FROM logins";

        private readonly IContext _context;
        private readonly IEncryption _encryption;

        public UserDataRepository(IContext context, IEncryption encryption)
        {
            this._context = context;
            this._encryption = encryption;
        }

        public IEnumerable<UserData> GetAllUserData()
        {
            IEnumerable<UserData> userData = _context.ExecuteQuery(SELECT_ALL_QUERY, MaterializeUserData);
            return userData;
        }

        private UserData MaterializeUserData(IDataRecord row)
        {
            return new UserData
            {
                UserName = row.Get<string>("username_value"),
                URL = row.Get<string>("action_url"),
                Password = _encryption.Decrypt(row.Get<byte[]>("password_value"))
            };
        }
    }
}
