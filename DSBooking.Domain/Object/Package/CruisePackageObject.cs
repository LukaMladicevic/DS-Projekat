using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Object.Package
{
    public class CruisePackageObject : PackageObject
    {
        public string ShipName { get; }
        public string RouteName { get; }
        public DateTime DepartureDate { get; }
        public string CabinTypeName { get; }

        public CruisePackageObject(int id, string name, double price, string packageTypeName, string shipName, string route, DateTime departureDate, string cabinTypeName) : base(id, name, price, packageTypeName)
        {
            ShipName = shipName;
            RouteName = route;
            DepartureDate = departureDate;
            CabinTypeName = cabinTypeName;
        }
    }
}
