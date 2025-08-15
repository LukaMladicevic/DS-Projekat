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
        public string AccommodationTypeName {  get; }

        public SeasidePackageObject(int id, string name, double price, string packageTypeName, string destinationName, string travelTypeName, string accommodationTypeName) : base(id, name, price, packageTypeName)
        {
            DestinationName = destinationName;
            TravelTypeName = travelTypeName;
            AccommodationTypeName = accommodationTypeName;
        }
    }
}
