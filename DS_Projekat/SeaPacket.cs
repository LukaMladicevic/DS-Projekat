using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking
{
    internal class SeaPacket : Packets
    {
        private String _destination;
        private String _transferType;
        private String _accomodationType;

        public SeaPacket(int packetID, string packetName, double price, String destination,String transferType,String accomodationType) : base(packetID, packetName, price)
        {
            this._destination = destination;
            this._transferType = transferType;
            this._accomodationType = accomodationType;
        }

        public override string packetDetails()
        {
            return _destination+" "+_transferType+" "+_accomodationType;
        }

        public override string packetType()
        {
            return "Sea Packet";
        }
    }
}
