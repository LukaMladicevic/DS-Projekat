using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Package
{
    internal class MountainPackage : Package
    {
        private string _destination;
        private string _transferType;
        private string _accomodationType;
        private string _activities;
        
        public String Destination
        {
            set { _destination = value; }
        }

        public String TransferType
        {
            set { _transferType = value; }
        }

        public String AccomodationType
        {
            set { _accomodationType = value; }
        }

        public String Activities
        {
            set { _activities = value; }
        }

        public override string packetType()
        {
            return "Mountain packet";
        }
        public override string packetDetails()
        {
            return base.packetDetails() + _destination + " " + _transferType + " " + _accomodationType + " " + _activities;
        }
    }
}
