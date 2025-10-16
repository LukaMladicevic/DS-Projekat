using DSBooking.Domain.Error;
using DSBooking.Domain.Object.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Service
{
    public class DomainPackageService : IDomainService<PackageObject>
    {
        public IEnumerable<DomainError> CheckObject(PackageObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
