using DSBooking.Domain.Object.Package;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Mappers
{
    public interface IPackageFactory
    {
        PackageObject CreateFromReader(IDataRecord record);
    }
}
