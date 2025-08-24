using DSBooking.Domain.Object.Client;

namespace DSBooking.Infrastructure.Repository.Client
{
    public class TestClientRepository : IClientRepository
    {
        public int AddClient(ClientAddObject clientAddObject)
        {
            throw new NotImplementedException();
        }

        public ClientObject? Get(int id)
        {
            return null;
        }

        public IEnumerable<ClientObject> GetByFirstName(string filterString)
        {
            return new List<ClientObject>();
        }

        public IEnumerable<ClientObject> GetByLastName(string filterString)
        {
            return new List<ClientObject>();
        }

        public IEnumerable<ClientObject> GetByPassportNo(string filterString)
        {
            return new List<ClientObject>();
        }

        public void RemoveClient(int clientId)
        {
            throw new NotImplementedException();
        }
    }

}
