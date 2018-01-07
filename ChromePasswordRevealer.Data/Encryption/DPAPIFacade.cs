using ChromePasswordRevealer.Data.Encryption.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromePasswordRevealer.Data.Encryption
{
    public class DPAPIFacade : IEncryption
    {
        public string Decrypt(byte[] encryptedData)
        {
            string decryptedText = new UTF8Encoding(true)
                .GetString(DPAPI.Decrypt(encryptedData, null, out string description));

            return decryptedText;
        }
    }
}
