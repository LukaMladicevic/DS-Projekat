using DSBooking.Domain.Object.Client;

namespace DSBooking.Infrastructure.Repository.Client
{
    public class TestClientRepository : IClientRepository
    {
        public void AddClient(ClientAddObject clientAddObject)
        {
        }

        public ClientObject? Get(int id)
        {
            return null;
        }

        public IEnumerable<ClientObject> GetClientsByName(string nameSubstring)
        {
            return new List<ClientObject>();
        }
    }

}
