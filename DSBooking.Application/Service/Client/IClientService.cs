using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Application.Service.Client
{
    public interface IClientService
    {
        IEnumerable<ClientEntity> GetByFirstName(string filterString);
        IEnumerable<ClientEntity> GetByLastName(string filterString);
        IEnumerable<ClientEntity> GetByPassportNo(string filterString);

        // returns ID
        int AddClient(ClientAddObject client);
        void RemoveClient(int clientId);
    }
}
