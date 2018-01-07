﻿using ChromePasswordRevealer.Data.Connection_String.Abstract;
using ChromePasswordRevealer.Data.Context.Abstract;
using ChromePasswordRevealer.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace ChromePasswordRevealer.Data.Context
{
    public class Context : IContext
    {
        private readonly IConnectionString connectionString;

        public Context(IConnectionString connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<T> ExecuteQuery<T>(string query, Func<IDataRecord, T> materializeTable)
        {
            using (SQLiteConnection sqLite = new SQLiteConnection(connectionString.GetConnectionString()))
            {
                sqLite.Open();

                using (SQLiteCommand cmd = sqLite.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;

                    return cmd.Materialize(materializeTable);
                }
            }
        }
    }
}
