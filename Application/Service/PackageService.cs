using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;
using DSBooking.Domain.Repository;
using DSBooking.Domain.Service.Interface;

namespace DSBooking.Domain.Service.Implementation
{
    public class PackageService : IPackageService
    {
        IPackageRepository _packageRepository;

        public PackageService(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public IEnumerable<Package> GetAllPackages()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Package> GetAvailablePackages()
        {
            throw new NotImplementedException();
        }
    }
}
