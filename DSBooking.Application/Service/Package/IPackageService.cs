using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Package;

namespace DSBooking.Application.Service.Package
{
    public interface IPackageService
    {
        IEnumerable<PackageEntity> GetAllAvailableForClient(int clientId);
        IEnumerable<PackageEntity> GetAll();
    }
}
