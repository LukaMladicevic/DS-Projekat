using System;
using System.Text;

namespace DSBooking.Infrastructure.Encryptor
{
    public class BasicEncryptor : IEncryptor
    {
        private const int SHIFT = 4;

        public string Encrypt(string key)
        {
            return key;
        }

        public string Decrypt(string key)
        {
            return key;
        }
    }
}