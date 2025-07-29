using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking
{
    internal class CruisePacket : Packets
    {
        private String _boatName;
        private String _route; //? niz?
        private String _date;
        private String _cabineType;

        public CruisePacket(int packetID, string packetName, double price,String boatname,String route,String date,String cabineType) : base(packetID, packetName, price)
        {
            this._boatName = boatname;
            this._route = route;
            this._date = date;
            this._cabineType = cabineType;
        }

        public override string packetDetails()
        {
            return _boatName + " " + _route + " " + _date + " " + _cabineType;
        }

        public override string packetType()
        {
            return "Cruise Packet";
        }
    }
}
