using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;
using DSBooking.Domain.Repository;

namespace DSBooking.Infrastructure
{
    public class PackageRepository : IPackageRepository
    {
        public IEnumerable<Package> GetAllPackages()
        {
            throw new NotImplementedException();
        }
    }
}
