using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;

namespace DSBooking.Domain.Service.Interface
{
    public interface IPackageService
    {
        IEnumerable<Package> GetAllPackages();
        IEnumerable<Package> GetAvailablePackages();

        /// ???
    }
}
