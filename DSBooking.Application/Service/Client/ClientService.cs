using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Error;
using DSBooking.Domain.Object.Client;
using DSBooking.Domain.Service;
using DSBooking.Infrastructure.Repository.Client;

namespace DSBooking.Application.Service.Client
{
    public class ClientService : IClientService
    {
        IClientRepository _clientRepository;
        DomainClientService _domainService;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
            _domainService = new DomainClientService();
        }

        public AddResult AddClient(ClientAddObject client)
        {
            IEnumerable<DomainError> errors = _domainService.CheckClientAddObject(client);

            if(!errors.Any())
                _clientRepository.AddClient(client);

            return new AddResult(errors);
        }

        public IEnumerable<ClientObject> GetByFirstName(string filterString)
        {
            return _clientRepository.GetByFirstName(filterString);
        }

        public IEnumerable<ClientObject> GetByLastName(string filterString)
        {
            return _clientRepository.GetByLastName(filterString);
        }

        public IEnumerable<ClientObject> GetByPassportNo(string filterString)
        {
            return _clientRepository.GetByPassportNo(filterString);
        }

        public void RemoveClient(int clientId)
        {
            _clientRepository.RemoveClient(clientId);
        }
    }
}
