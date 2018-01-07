using ChromePasswordRevealer.Data.Connection_String.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromePasswordRevealer.Data.Connection_String
{
    public class ConnectionString : IConnectionString
    {
        public string GetConnectionString()
        {
            var connectionVariable = @"%USERPROFILE%\AppData\Local\Google\Chrome\User Data\Default\Login Data";
            var connectionString = string.Format("data source={0}", Environment.ExpandEnvironmentVariables(connectionVariable));

            return connectionString;
        }
    }
}
