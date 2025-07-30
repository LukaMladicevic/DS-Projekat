using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Packets
{
    internal class SeaPacket : Packets
    {
        private String _destination;
        private String _transferType;
        private String _accomodationType;

        public String Destination
        {
            set {  _destination = value; }
        }

        public String TransferType
        {
            set { _transferType = value; }
        }

        public String AccomodationType
        {
            set { _accomodationType = value; }
        }

        public override string packetType()
        {
            return "Sea packet";
        }
        public override string packetDetails()
        {
            return base.packetDetails() + _destination + " " + _transferType + " " + _accomodationType;
        }
    }
}
