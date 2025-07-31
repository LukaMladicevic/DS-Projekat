using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Package
{
    internal class SeaPackageBuilder : IPackageBuilder
    {
        SeaPackage p;

        public SeaPackageBuilder()
        {
            p = new SeaPackage();
        }

        public void reset()
        {
            p = new SeaPackage();
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

        public void accomodationType(String accomodation)
        {
            p.AccomodationType = accomodation;
        }

        public Package returnPacket()
        {
            Package product = p;
            this.reset();
            return product;
        }
    }
}
