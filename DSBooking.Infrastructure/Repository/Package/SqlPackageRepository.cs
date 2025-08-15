using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Package;

namespace DSBooking.Infrastructure.Repository.Package
{
    public class SqlPackageRepository : IPackageRepository
    {
        public PackageObject? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PackageObject> GetAllAvailablePackages(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
