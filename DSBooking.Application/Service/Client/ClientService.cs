using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
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

        public int AddClient(ClientAddObject client)
        {
            return _clientRepository.AddClient(client);
        }

        public IEnumerable<ClientEntity> GetByFirstName(string filterString)
        {
            return _clientRepository.GetByFirstName(filterString);
        }

        public IEnumerable<ClientEntity> GetByLastName(string filterString)
        {
            return _clientRepository.GetByLastName(filterString);
        }

        public IEnumerable<ClientEntity> GetByPassportNo(string filterString)
        {
            return _clientRepository.GetByPassportNo(filterString);
        }

        public void RemoveClient(int clientId)
        {
            _clientRepository.RemoveClient(clientId);
        }
    }
}
