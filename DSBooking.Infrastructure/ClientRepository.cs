using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Repository;

namespace DSBooking.Infrastructure
{
    public class ClientRepository : IClientRepository
    {
        List<Client> _clients = new List<Client> ();
        public ClientRepository()
        {
            _clients.Add(new Client(1, "Novak", "Stevanovic", "1", new DateOnly(2003, 10, 24), "novakst24@gmail.com", "0603498540"));
            _clients.Add(new Client(2, "Emilija", "Djordjevic", "2", new DateOnly(2003, 7, 29), "emilijadjordjevic.com@gmail.com", "neznambroj"));
        }
        public void AddClient(Client c)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClientsByName(string nameSubstring)
        {
            return (from c in _clients
                    where c.Name.Contains(nameSubstring)
                    select c).ToList();
        }
    }
}
