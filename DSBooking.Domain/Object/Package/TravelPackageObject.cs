using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Object.Package
{
    public class TravelPackageObject : PackageObject
    {
        public string DestinationName { get; }
        public string TravelTypeName { get; }
        public string GuideName { get; }
        public int Duration { get; }

        public TravelPackageObject(int id, string name, double price, string packageTypeName, string destinationName, string travelTypeName, string guideName, int duration) : base(id, name, price, packageTypeName)
        {
            DestinationName = destinationName;
            TravelTypeName = travelTypeName;
            GuideName = guideName;
            Duration = duration;
        }
    }
}
