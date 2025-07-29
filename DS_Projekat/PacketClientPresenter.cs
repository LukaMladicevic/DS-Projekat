using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking
{
    internal class PacketClientPresenter : IClientPresenter // TO EXPAND INTERFACE
    {
        List<Packets> allPackets;
        Database db = Database.Instance;
        PacketFactory pf;
        public PacketClientPresenter()
        {
            allPackets = new List<Packets>();
            pf = new PacketFactory();
        }

        public void loadAllPackets()
        {
            IDataReader reader;
            reader = db.query("SELECT * FROM SEA");
            while (reader.Read())
            {
                object[] row = new object[reader.FieldCount];
                reader.GetValues(row);
                Packets p = pf.returnPacket(PacketTypeEnum.SEA, row);
                allPackets.Add(p);
            }

            reader = db.query("SELECT * FROM MOUNTAIN");
            while (reader.Read())
            {
                object[] row = new object[reader.FieldCount];
                reader.GetValues(row);
                Packets p = pf.returnPacket(PacketTypeEnum.MOUNTAIN, row);
                allPackets.Add(p);
            }

            reader = db.query("SELECT * FROM TRIP");
            while (reader.Read())
            {
                object[] row = new object[reader.FieldCount];
                reader.GetValues(row);
                Packets p = pf.returnPacket(PacketTypeEnum.TRIP, row);
                allPackets.Add(p);
            }

            reader = db.query("SELECT * FROM CRUISE");
            while (reader.Read())
            {
                object[] row = new object[reader.FieldCount];
                reader.GetValues(row);
                Packets p = pf.returnPacket(PacketTypeEnum.CRUISE, row);
                allPackets.Add(p);
            }

        }
         
    }
}
