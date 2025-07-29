using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking
{
    internal abstract class Packets
    {
        private int _packetID;
        private String _packetName;
        private double _price;
        public String PacketName
        {
            get
            {
                return _packetName;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }

        public Packets(int packetID,String packetName,double price)
        {
            this._packetID = packetID;
            this._packetName = packetName;
            this._price= price;
        }

        public abstract String packetType();

        public abstract String packetDetails();
    }
}
