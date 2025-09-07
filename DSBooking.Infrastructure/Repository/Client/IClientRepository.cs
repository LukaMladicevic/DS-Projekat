using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Infrastructure.Repository.Client
{
    public interface IClientRepository
    {
        public ClientEntity? Get(int id);
        IEnumerable<ClientEntity> GetByFirstName(string filterString);

        IEnumerable<ClientEntity> GetByLastName(string filterString);
        IEnumerable<ClientEntity> GetByPassportNo(string filterString);

        // returns ID
        int AddClient(ClientAddObject clientAddObject);
        void RemoveClient(int clientId);
    }
}
