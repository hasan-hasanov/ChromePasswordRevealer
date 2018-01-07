using System;
using System.Collections.Generic;
using System.Text;

namespace ChromePasswordRevealer.Data.Models
{
    public class UserData
    {
        public string URL { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] PasswordBLOB { get; set; }
    }
}
