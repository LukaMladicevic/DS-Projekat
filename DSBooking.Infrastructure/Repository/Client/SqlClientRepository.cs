using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Infrastructure.Mappers;

namespace DSBooking.Infrastructure.Repository.Client
{
    public class SqlClientRepository : Repository<ClientEntity>, IClientRepository
    {
        public SqlClientRepository(IMapper<ClientEntity> mapper) : base(mapper) { }
        public int AddClient(ClientAddObject clientAddObject)
        {
            throw new NotImplementedException();
        }

        public ClientEntity? Get(int id)
        {
            throw new NotImplementedException();
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
