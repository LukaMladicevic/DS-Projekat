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

        private TravelPackageObject(int id, string name, double price, string packageTypeName, string destinationName, string travelTypeName, string guideName, int duration)
            : base(id, name, price, packageTypeName)
        {
            DestinationName = destinationName;
            TravelTypeName = travelTypeName;
            GuideName = guideName;
            Duration = duration;
        }

        public class Builder : PackageBuilder<Builder>
        {
            private string destinationName;
            private string travelTypeName;
            private string guideName;
            private int duration;

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

            public Builder WithGuideName(string guideName)
            {
                this.guideName = guideName;
                return this;
            }

            public Builder WithDuration(int duration)
            {
                this.duration = duration;
                return this;
            }

            public override PackageObject Build()
            {
                if (string.IsNullOrEmpty(destinationName)) throw new ArgumentException("DestinationName is required.");

                return new TravelPackageObject(id, name, price, packageTypeName, destinationName, travelTypeName, guideName, duration);
            }
        }
    }
}
