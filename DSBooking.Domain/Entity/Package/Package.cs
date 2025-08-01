using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Package
{
    public abstract class Package
    {
        private int _packetID;
        private string _packetName;
        private double _price;

        public int packetID
        {
            set { _packetID = value; }
        }
        public string PacketName
        {
            set { _packetName = value; }
            get
            {
                return _packetName;
            }
        }
        public double Price
        {
            set { _price = value; }
            get
            {
                return _price;
            }
        }

        public virtual string packetDetails()
        {
            return " " + PacketName + " " + Price;
        }

        public abstract string packetType();

        
    }
}
