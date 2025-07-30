using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Packets
{
    internal class CruisePacketBuilder
    {
        CruisePacket p;

        public CruisePacketBuilder()
        {
            p = new CruisePacket();
        }

        public void reset()
        {
            p = new CruisePacket();
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

        public void boatName(String boatName)
        {
            p.BoatName = boatName;
        }

        public void route(String route)
        {
            p.Route = route;
        }

        public void date(String date)
        {
            p.Date = date;
        }

        public void cabineType(String cabineType)
        {
            p.CabineType = cabineType;
        }

        public Packets returnPacket()
        {
            Packets product = p;
            this.reset();
            return product;
        }
    }
}
