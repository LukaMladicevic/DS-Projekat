using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Repository;

namespace DSBooking.Domain.Service.Implementation
{
    public class ClientService : IClientService
    {
        IClientRepository _clientRepository;

        List<Client> clients = new List<Client>();

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;

            clients.Add(new Client(1, "novak", "stevanovic", "1", new DateOnly(2003, 10, 24), "novakst24@gmail.com", "broj1"));
            clients.Add(new Client(2, "emilija", "djordjevic", "1", new DateOnly(2003, 7, 29), "emilijadjordjevic.com@gmail.com", "broj2"));
        }

        public IEnumerable<Client> GetClientsByName(string nameSubstring)
        {
            return (from Client client in clients
                    where client.Name.Contains(nameSubstring)
                    select client).ToList();
        }
    }
}
