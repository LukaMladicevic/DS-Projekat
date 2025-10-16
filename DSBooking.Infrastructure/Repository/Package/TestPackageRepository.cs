using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Package;

namespace DSBooking.Infrastructure.Repository.Package
{
    public class TestPackageRepository : IPackageRepository
    {
        public int AddPackage(PackageObject package)
        {
            throw new NotImplementedException();
        }

        public PackageObject? Get(int id)
        {
            return null;
        }

        public IEnumerable<PackageObject> GetAll()
        {
            return new List<PackageObject>();
        }

        public IEnumerable<PackageObject> GetAllAvailableForClient(int clientId)
        {
            return new List<PackageObject>();
        }
    }
}
