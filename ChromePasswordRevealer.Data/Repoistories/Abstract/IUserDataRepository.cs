using ChromePasswordRevealer.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromePasswordRevealer.Data.Repoistories.Abstract
{
    public interface IUserDataRepository
    {
        IEnumerable<UserData> GetAllUserData();
    }
}
