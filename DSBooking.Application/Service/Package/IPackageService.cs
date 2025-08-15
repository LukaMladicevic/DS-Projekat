using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Package;

namespace DSBooking.Application.Service.Package
{
    public interface IPackageService
    {
        IEnumerable<PackageObject> GetAll();
    }
}
