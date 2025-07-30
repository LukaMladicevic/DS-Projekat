using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Packets
{
    internal class CruisePacket : Packets
    {
        private string _boatName;
        private string _route; //? niz?
        private string _date;
        private string _cabineType;

        public String BoatName
        {
            set { _boatName = value; }
        }

        public String Route
        {
            set { _route = value; }
        }

        public String Date
        {
            set { _date = value; }
        }

        public String CabineType
        {
            set { _cabineType = value; }
        }

        public override string packetType()
        {
            return "Cruise packet";
        }
        public override string packetDetails()
        {
            return base.packetDetails() + _boatName + " " + _route + " " + _date + " " + _cabineType;
        }
    }
}
