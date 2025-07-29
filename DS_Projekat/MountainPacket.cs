using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking
{
    internal class MountainPacket : Packets
    {
        private String _destination;
        private String _transferType;
        private String _accomodationType;
        private String _activities;

        public MountainPacket(int packetID, string packetName, double price, String destination, String transferType, String accomodationType, String activities) : base(packetID, packetName, price)
        {
            this._destination = destination;
            this._transferType = transferType;
            this._accomodationType = accomodationType;
            this._activities = activities;
        }

        public override string packetDetails()
        {
            return _destination + " " + _transferType + " " + _accomodationType+" "+_activities;
        }

        public override string packetType()
        {
            return "Mountain Packet";
        }
    }
}
