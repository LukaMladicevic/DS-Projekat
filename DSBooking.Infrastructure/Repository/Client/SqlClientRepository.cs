using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;

namespace DSBooking.Infrastructure.Repository.Client
{
    public class SqlClientRepository : IClientRepository
    {
        public int AddClient(ClientAddObject clientAddObject)
        {
            throw new NotImplementedException();
        }

        public ClientObject? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientObject> GetByFirstName(string filterString)
        {
            return new List<ClientObject>();
        }

        public IEnumerable<ClientObject> GetByLastName(string filterString)
        {
            return new List<ClientObject>();
        }

        public IEnumerable<ClientObject> GetByPassportNo(string filterString)
        {
            return new List<ClientObject>();
        }

        public void RemoveClient(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
