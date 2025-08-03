using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Infrastructure.Repository.Client
{
    public interface IClientRepository : IRepository<ClientEntity>
    {
        public IEnumerable<ClientEntity> GetClientsByName(string nameSubstring);
    }
}
