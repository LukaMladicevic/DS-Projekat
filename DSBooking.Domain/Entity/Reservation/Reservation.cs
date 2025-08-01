using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Reservation
{
    public class Reservation
    {
        public int Id { get; private set; }
        public int ClientId { get; private set; }
        public int PackageId { get; private set; }

        public Reservation(int id, int clientId, int packageId)
        {
            Id = id;
            ClientId = clientId;
            PackageId = packageId;
        }

    }
}
