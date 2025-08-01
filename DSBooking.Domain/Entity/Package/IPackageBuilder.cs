using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Package
{
    public interface IPackageBuilder
    {
        public void reset();
        public void setID(int id);
        public void setPacketName(string name);
        public void setPrice(float price);

        public Package returnPacket();
        
    }
}
