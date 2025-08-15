using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Package;
using DSBooking.Infrastructure.Repository.Package;

namespace DSBooking.Application.Service.Package
{
    public class PackageService : IPackageService
    {
        IPackageRepository _packageRepository;
        public PackageService(IPackageRepository packageRepository) 
        {
            _packageRepository = packageRepository;
        }

        public IEnumerable<PackageObject> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
