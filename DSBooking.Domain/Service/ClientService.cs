using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Repository;

namespace DSBooking.Domain.Service
{
    public class ClientService : IClientService
    {
        IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;        
        }
    }
}
