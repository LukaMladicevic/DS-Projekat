using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;
using DSBooking.Infrastructure.Encryptor;

namespace DSBooking.Infrastructure.Repository.Client
{
    // DECORATOR PATTERN
    public class EncryptedClientRepository : IClientRepository
    {
        IClientRepository _wrapped;
        IEncryptor _encryptor;

        public EncryptedClientRepository(IClientRepository clientRepository, IEncryptor encryptor)
        {
            _wrapped = clientRepository;
            _encryptor = encryptor;
        }

        private ClientObject DecryptFields(ClientObject clientObject)
        {
            return new ClientObject(clientObject.Id, clientObject.FirstName, clientObject.LastName, _encryptor.Decrypt(clientObject.PassportNo), clientObject.DateOfBirth, clientObject.Email, clientObject.PhoneNo);
        }

        private ClientAddObject EncryptFields(ClientAddObject clientAddObject)
        {
            return new ClientAddObject(clientAddObject.FirstName, clientAddObject.LastName, _encryptor.Encrypt(clientAddObject.PassportNo), clientAddObject.DateOfBirth, clientAddObject.Email, clientAddObject.PhoneNo);
        }

        public void AddClient(ClientAddObject clientAddObject)
        {
            _wrapped.AddClient(EncryptFields(clientAddObject));
        }

        public ClientObject? Get(int id)
        {
            ClientObject? encrypted = _wrapped.Get(id);
            return encrypted == null ? null : DecryptFields(encrypted);
        }

        public IEnumerable<ClientObject> GetByFirstName(string filterString)
        {
            IEnumerable<ClientObject> encrypted = _wrapped.GetByFirstName(filterString);
            List<ClientObject> decrypted = new List<ClientObject>();

            foreach (ClientObject client in encrypted)
                decrypted.Add(DecryptFields(client));

            return decrypted;
        }

        public IEnumerable<ClientObject> GetByLastName(string filterString)
        {
            IEnumerable<ClientObject> encrypted = _wrapped.GetByLastName(filterString);
            List<ClientObject> decrypted = new List<ClientObject>();

            foreach (ClientObject client in encrypted)
                decrypted.Add(DecryptFields(client));

            return decrypted;
        }

        public IEnumerable<ClientObject> GetByPassportNo(string filterString)
        {
            IEnumerable<ClientObject> encrypted = _wrapped.GetByPassportNo(filterString);
            List<ClientObject> decrypted = new List<ClientObject>();

            foreach (ClientObject client in encrypted)
                decrypted.Add(DecryptFields(client));

            return decrypted;
        }

        public void RemoveClient(int clientId)
        {
            _wrapped.RemoveClient(clientId);
        }
    }
}
