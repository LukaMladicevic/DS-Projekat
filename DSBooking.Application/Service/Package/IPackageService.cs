using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Package;

namespace DSBooking.Application.Service.Package
{
    public interface IPackageService
    {
        IEnumerable<PackageDTO> GetAllPackages();
        /// ???
    }
}
