using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Application.Service.Client
{
    public interface IEncryptor
    {
        public string Encrypt(string key);
        public bool VerifyHash(string input, string stored);
    }
}
