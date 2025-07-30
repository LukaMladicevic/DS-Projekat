using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Packets
{
    internal class TripPacket : Packets
    {
        private string _destination;
        private string _transferType;
        private string _guide;
        private int _duration;

        public String Destination
        {
            set { _destination = value; }
        }

        public String TransferType
        {
            set { _transferType = value; }
        }

        public String Guide
        {
            set { _guide = value; }
        }

        public int Duration
        {
            set { _duration = value; }
        }

        public override string packetType()
        {
            return "Trip packet";
        }
        public override string packetDetails()
        {
            return base.packetDetails() + _destination + " " + _transferType + " " + _guide + " " + _duration;
        }
    }
}
