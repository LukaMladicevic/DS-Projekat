using DSBooking.Domain.Entity.Client;

namespace DSBooking.Infrastructure.Repository.Client
{
    public class TestClientRepository : TestRepository<ClientEntity>, IClientRepository
    {
        List<ClientEntity> _clients = new List<ClientEntity>();
        public TestClientRepository()
        {
            _clients.Add(new ClientEntity(1, "Novak", "Stevanovic", "1", new DateOnly(2003, 10, 24), "novakst24@gmail.com", "0603498540"));
            _clients.Add(new ClientEntity(2, "Emilija", "Djordjevic", "2", new DateOnly(2003, 7, 29), "emilijadjordjevic.com@gmail.com", "555333"));
        }

        public IEnumerable<ClientEntity> GetClientsByName(string nameSubstring)
        {
            return (from c in _clients
                    where c.Name.Contains(nameSubstring)
                    select c).ToList();
        }

    }
}
