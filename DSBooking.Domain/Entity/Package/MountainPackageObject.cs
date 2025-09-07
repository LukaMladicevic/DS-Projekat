using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Package
{
    public class MountainPackageObject : PackageEntity
    {
        public string DestinationName { get; }
        public string TravelTypeName { get; }
        public string AccommodationTypeName { get; }
        public string AdditionalActivities { get; }

        public MountainPackageObject(int id, string name, double price, string packageTypeName, string destinationName, string travelTypeName, string accommodationTypeName, string additionalActivities) : base(id, name, price, packageTypeName)
        {
            DestinationName = destinationName;
            TravelTypeName = travelTypeName;
            AccommodationTypeName = accommodationTypeName;
            AdditionalActivities = additionalActivities;
        }
    }
}
