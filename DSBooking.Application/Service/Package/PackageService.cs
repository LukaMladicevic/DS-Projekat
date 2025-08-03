using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Package;
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

        public IEnumerable<PackageDTO> GetAllPackages()
        {
            IEnumerable<PackageEntity> packages = _packageRepository.GetAll();
            List<PackageDTO> result = new List<PackageDTO>();

            foreach (PackageEntity package in packages)
            {
                result.Add(new PackageDTO {
                    Id = package.Id,
                    Name = package.Name,
                    Price = package.Price,
                });

            }

            return result;

        }
    }
}
