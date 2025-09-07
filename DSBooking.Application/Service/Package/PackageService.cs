using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;
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
        public IEnumerable<PackageEntity> GetAll()
        {
            return _packageRepository.GetAll();
        }
        public IEnumerable<PackageEntity> GetAllAvailableForClient(int clientId)
        {
            return _packageRepository.GetAllAvailableForClient(clientId);
        }
    }
}
