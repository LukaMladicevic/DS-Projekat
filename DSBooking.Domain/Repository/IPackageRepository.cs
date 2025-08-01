using DSBooking.Domain.Entity.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Repository
{
    public interface IPackageRepository
    {
        IEnumerable<Package> GetAllPackages();
    }
}
