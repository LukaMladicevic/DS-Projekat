using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;
using DSBooking.Infrastructure.Repository.Client;

namespace DSBooking.Application.Service.Client
{
    public class ClientService : IClientService
    {
        IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<ClientObject> GetByName(string name)
        {
            return _clientRepository.GetClientsByName(name);
        }
    }
}
