using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Infrastructure.Repository.Client
{
    public class SqlClientRepository : IClientRepository
    {
        public void Add(ClientEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClientEntity? GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(ClientEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientEntity> GetClientsByName(string nameSubstring)
        {
            throw new NotImplementedException();
        }

    }
}
