using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Package
{
    public class MountainPackageBuilder
    {
        MountainPackage p;

        public MountainPackageBuilder()
        {
            p = new MountainPackage();
        }

        public void reset()
        {
            p = new MountainPackage();
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
        public void activities(String activities)
        {
            p.Activities = activities;
        }

        public Package returnPacket()
        {
            Package product = p;
            this.reset();
            return product;
        }
    }
}
