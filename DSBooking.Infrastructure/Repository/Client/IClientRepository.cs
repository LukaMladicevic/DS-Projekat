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
        public IEnumerable<ClientObject> GetClientsByName(string nameSubstring);
        public void AddClient(ClientAddObject clientAddObject);
    }
}
