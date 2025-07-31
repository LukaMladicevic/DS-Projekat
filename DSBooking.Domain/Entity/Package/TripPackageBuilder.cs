using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Package
{
    internal class TripPackageBuilder
    {
        TripPackage p;

        public TripPackageBuilder()
        {
            p = new TripPackage();
        }

        public void reset()
        {
            p = new TripPackage();
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

        public Package returnPacket()
        {
            Package product = p;
            this.reset();
            return product;
        }
    }
}
