using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Repository;

namespace DSBooking.Domain.Service
{
    public class PackageService : IPackageService
    {
        IPackageRepository _packageRepository;

        public PackageService(IPackageRepository packageRepository) 
        {
            _packageRepository = packageRepository;
        }
    }
}
