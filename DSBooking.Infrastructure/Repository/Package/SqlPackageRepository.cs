using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;

namespace DSBooking.Infrastructure.Repository.Package
{
    public class SqlPackageRepository : IPackageRepository
    {
        public PackageEntity? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PackageEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PackageEntity> GetAllAvailableForClient(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
