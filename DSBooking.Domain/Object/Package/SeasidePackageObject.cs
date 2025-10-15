using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Object.Package
{
    public class SeasidePackageObject : PackageObject
    {
        public string DestinationName { get; }
        public string TravelTypeName { get; }
        public string AccommodationTypeName { get; }

        private SeasidePackageObject(int id, string name, double price, string packageTypeName, string destinationName, string travelTypeName, string accommodationTypeName)
            : base(id, name, price, packageTypeName)
        {
            DestinationName = destinationName;
            TravelTypeName = travelTypeName;
            AccommodationTypeName = accommodationTypeName;
        }

        public class Builder : PackageBuilder<Builder>
        {
            private string destinationName;
            private string travelTypeName;
            private string accommodationTypeName;

            public Builder WithDestinationName(string destinationName)
            {
                this.destinationName = destinationName;
                return this;
            }

            public Builder WithTravelTypeName(string travelTypeName)
            {
                this.travelTypeName = travelTypeName;
                return this;
            }

            public Builder WithAccommodationTypeName(string accommodationTypeName)
            {
                this.accommodationTypeName = accommodationTypeName;
                return this;
            }

            public override PackageObject Build()
            {
                // Add validation if needed, e.g., check required fields
                if (string.IsNullOrEmpty(destinationName)) throw new ArgumentException("DestinationName is required.");
                // Similarly for other fields...

                return new SeasidePackageObject(id, name, price, packageTypeName, destinationName, travelTypeName, accommodationTypeName);
            }
        }
    }
}
