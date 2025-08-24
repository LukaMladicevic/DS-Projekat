using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;

namespace DSBooking.Application.Service.Client
{
    public interface IClientService
    {
        IEnumerable<ClientObject> GetByFirstName(string filterString);
        IEnumerable<ClientObject> GetByLastName(string filterString);
        IEnumerable<ClientObject> GetByPassportNo(string filterString);

        // returns ID
        int AddClient(ClientAddObject client);
        void RemoveClient(int clientId);
    }
}
