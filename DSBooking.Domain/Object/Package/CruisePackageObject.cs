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

        private CruisePackageObject(int id, string name, double price, string packageTypeName, string shipName, string routeName, DateTime departureDate, string cabinTypeName)
            : base(id, name, price, packageTypeName)
        {
            ShipName = shipName;
            RouteName = routeName;
            DepartureDate = departureDate;
            CabinTypeName = cabinTypeName;
        }

        public class Builder : PackageBuilder<Builder>
        {
            private string shipName;
            private string routeName;
            private DateTime departureDate;
            private string cabinTypeName;

            public Builder WithShipName(string shipName)
            {
                this.shipName = shipName;
                return this;
            }

            public Builder WithRouteName(string routeName)
            {
                this.routeName = routeName;
                return this;
            }

            public Builder WithDepartureDate(DateTime departureDate)
            {
                this.departureDate = departureDate;
                return this;
            }

            public Builder WithCabinTypeName(string cabinTypeName)
            {
                this.cabinTypeName = cabinTypeName;
                return this;
            }

            public override PackageObject Build()
            {
                // Add validation if needed, e.g., check required fields
                if (string.IsNullOrEmpty(shipName)) throw new ArgumentException("ShipName is required.");
                // Similarly for other fields...

                return new CruisePackageObject(id, name, price, packageTypeName, shipName, routeName, departureDate, cabinTypeName);
            }
        }
    }
}
