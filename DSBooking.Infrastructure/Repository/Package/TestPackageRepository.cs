using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;

namespace DSBooking.Infrastructure.Repository.Package
{
    public class TestPackageRepository : IPackageRepository
    {
        public PackageEntity? Get(int id)
        {
            return null;
        }

        public IEnumerable<PackageEntity> GetAll()
        {
            return new List<PackageEntity>();
        }

        public IEnumerable<PackageEntity> GetAllAvailableForClient(int clientId)
        {
            return new List<PackageEntity>();
        }
    }
}
