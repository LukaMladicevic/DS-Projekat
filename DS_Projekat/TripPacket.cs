using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking
{
    internal class TripPacket : Packets
    {
        private String _destination;
        private String _transferType;
        private String _guide;
        private int _duration;

        public TripPacket(int packetID, string packetName, double price, String destination, String transferType, String guide, int duration) : base(packetID, packetName, price)
        {
            this._destination = destination;
            this._transferType = transferType;
            this._guide = guide;
            this._duration = duration;
        }

        public override string packetDetails()
        {
            return _destination + " " + _transferType + " " + _guide + " " + _duration;
        }

        public override string packetType()
        {
            return "Trip Packet";
        }
    }
}
