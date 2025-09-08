using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Encryptor
{
    public interface IEncryptor
    {
        string Encrypt(string key);
        string Decrypt(string key);
    }
}