using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Packets
{
    internal class TripPacketBuilder
    {
        TripPacket p;

        public TripPacketBuilder()
        {
            p = new TripPacket();
        }

        public void reset()
        {
            p = new TripPacket();
        }

        public void setID(int id)
        {
            p.packetID = id;
        }

        public void setPacketName(string name)
        {
            p.PacketName = name;
        }

        public void setPrice(float price)
        {
            p.Price = price;
        }

        public void destination(String destination)
        {
            p.Destination = destination;
        }

        public void transferType(String transferType)
        {
            p.TransferType = transferType;
        }

        public void guide(String guide)
        {
            p.Guide = guide;
        }

        public Packets returnPacket()
        {
            Packets product = p;
            this.reset();
            return product;
        }
    }
}
