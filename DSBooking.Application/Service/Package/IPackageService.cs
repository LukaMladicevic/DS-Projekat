using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;
using DSBooking.Domain.Object.Package;

namespace DSBooking.Application.Service.Package
{
    public interface IPackageService
    {
        IEnumerable<PackageObject> GetAllAvailableForClient(int clientId);
        IEnumerable<PackageObject> GetAll();
        AddResult AddPackage(PackageObject packageObject);
    }
}
