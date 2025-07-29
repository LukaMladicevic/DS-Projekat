using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking
{
    internal class PacketFactory
    {
        public Packets returnPacket(PacketTypeEnum type, object[] data)
        {
            // Posto su svi podaci spakovani u niz objekata, svi moraju da se kastuju u respektabilan tip
            switch (type)
            {
                case PacketTypeEnum.SEA:
                    SeaPacket sp = new SeaPacket((int) data[0], (String)data[1], (double) data[2], (String) data[3], (String)data[4], (String)data[5]);
                    return sp;
                    
                case PacketTypeEnum.MOUNTAIN:
                        
                    MountainPacket mp = new MountainPacket((int)data[0], (String)data[1], (double)data[2], (String)data[3], (String)data[4], (String)data[5],(String)data[6]);
                    return mp;
                    
                case PacketTypeEnum.TRIP:
                    
                    TripPacket tp = new TripPacket((int)data[0], (String)data[1], (double)data[2], (String)data[3], (String)data[4], (String)data[5], (int)data[6]);
                    return tp;
                    
                case PacketTypeEnum.CRUISE:

                    CruisePacket cp = new CruisePacket((int)data[0], (String)data[1], (double)data[2], (String)data[3], (String)data[4], (String)data[5], (String)data[6]);
                    return cp;

                default:
                    return null;
            }
        }

    }
}
