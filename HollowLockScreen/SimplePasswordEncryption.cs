using HollowLockScreen.Password;
using System;
using System.Text;

namespace HollowLockScreen
{
    internal class SimplePasswordEncryption
    {
        private string EncryptPassword(string newPassword)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(newPassword);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);

            return hash;
        }       
    }
}