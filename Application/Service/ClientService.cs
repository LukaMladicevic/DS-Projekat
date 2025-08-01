using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Repository;
using DSBooking.Domain.Service.Interface;

namespace DSBooking.Domain.Service.Implementation
{
    public class ClientService : IClientService
    {
        IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> GetClientsByName(string nameSubstring)
        {
            throw new NotImplementedException();
        }
    }
}
