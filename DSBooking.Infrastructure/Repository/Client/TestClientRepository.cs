using DSBooking.Domain.Object.Client;

namespace DSBooking.Infrastructure.Repository.Client
{
    public class TestClientRepository : IClientRepository
    {
        public void AddClient(ClientAddObject clientAddObject)
        {
            throw new NotImplementedException();
        }

        public ClientObject? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientObject> GetClientsByName(string nameSubstring)
        {
            throw new NotImplementedException();
        }
    }

}
