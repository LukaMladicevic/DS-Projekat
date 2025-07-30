using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Packets
{
    internal interface IPacketBuilder
    {
        public void reset();
        public void setID(int id);
        public void setPacketName(string name);
        public void setPrice(float price);

        public Packets returnPacket();
        
    }
}
