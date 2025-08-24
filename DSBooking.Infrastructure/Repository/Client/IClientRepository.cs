using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;

namespace DSBooking.Infrastructure.Repository.Client
{
    public interface IClientRepository
    {
        public ClientObject? Get(int id);
        IEnumerable<ClientObject> GetByFirstName(string filterString);

        IEnumerable<ClientObject> GetByLastName(string filterString);
        IEnumerable<ClientObject> GetByPassportNo(string filterString);

        // returns ID
        int AddClient(ClientAddObject clientAddObject);
        void RemoveClient(int clientId);
    }
}
