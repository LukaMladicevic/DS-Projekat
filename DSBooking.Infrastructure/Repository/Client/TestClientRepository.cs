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

        public IEnumerable<ClientObject> GetByFirstName(string filterString)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientObject> GetByLastName(string filterString)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientObject> GetByPassportNo(string filterString)
        {
            throw new NotImplementedException();
        }

        public int RemoveClient(int clientId)
        {
            throw new NotImplementedException();
        }
    }

}
