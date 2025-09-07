using DSBooking.Domain.Entity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DSBooking.Application.Service.Client
{
    public class ClientEncryptionService : IClientService, IEncryptor
    {
        IClientService _wrapped;

        public ClientEncryptionService(IClientService wrapped)
        {
            _wrapped = wrapped;
        }

        public int AddClient(ClientAddObject client)
        {
            var clientWithHashedPassword = new ClientAddObject(
                client.FirstName,
                client.LastName,
                client.PassportNo,
                client.DateOfBirth,
                client.Email,
                client.PhoneNo
            );

            _wrapped.AddClient(clientWithHashedPassword);
            return 1;
        }

        public string Encrypt(string key)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(key);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public IEnumerable<ClientEntity> GetByFirstName(string filterString)
        {
            return _wrapped.GetByFirstName(filterString);
        }

        public IEnumerable<ClientEntity> GetByLastName(string filterString)
        {
            return _wrapped.GetByLastName(filterString);
        }

        public IEnumerable<ClientEntity> GetByPassportNo(string filterString)
        {
            return _wrapped.GetByPassportNo(filterString);
        }

        public void RemoveClient(int clientId)
        {
            _wrapped.RemoveClient(clientId);
        }

        public bool VerifyHash(string input, string stored)
        {
            string inputHash = Encrypt(input);
            return string.Equals(stored, inputHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
