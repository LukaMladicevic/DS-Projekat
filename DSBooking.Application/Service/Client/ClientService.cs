using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Client;
using DSBooking.Domain.Entity;
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

        public IEnumerable<ClientDTO> GetClientsByName(string nameSubstring)
        {
            IEnumerable<ClientEntity> clients = _clientRepository.GetClientsByName(nameSubstring);
            List<ClientDTO> result = new List<ClientDTO>();
            foreach (ClientEntity client in clients)
            {
                result.Add(new ClientDTO
                {
                    Id = client.Id,
                    Name = client.Name,
                    EmailAddress = client.EmailAddress,
                    DateOfBirth = client.DateOfBirth,
                    PhoneNumber = client.PhoneNumber
                });
            }

            return result;

        }
    }
}
