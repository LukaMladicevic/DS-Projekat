using DSBooking.Domain.Entity.Client;

namespace DSBooking.Infrastructure.Repository.Client
{
    public class TestClientRepository : IClientRepository
    {
        public int AddClient(ClientAddObject clientAddObject)
        {
            throw new NotImplementedException();
        }

        public ClientEntity? Get(int id)
        {
            return null;
        }

        public IEnumerable<ClientEntity> GetByFirstName(string filterString)
        {
            return new List<ClientEntity>();
        }

        public IEnumerable<ClientEntity> GetByLastName(string filterString)
        {
            return new List<ClientEntity>();
        }

        public IEnumerable<ClientEntity> GetByPassportNo(string filterString)
        {
            return new List<ClientEntity>();
        }

        public void RemoveClient(int clientId)
        {
            throw new NotImplementedException();
        }
    }

}
