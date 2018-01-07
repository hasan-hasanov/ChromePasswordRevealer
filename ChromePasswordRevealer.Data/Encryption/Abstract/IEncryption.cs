using System;
using System.Collections.Generic;
using System.Text;

namespace ChromePasswordRevealer.Data.Encryption.Abstract
{
    public interface IEncryption
    {
        string Decrypt(byte[] encryptedData);
    }
}
