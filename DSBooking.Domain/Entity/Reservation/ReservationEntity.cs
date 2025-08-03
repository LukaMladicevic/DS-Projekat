using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity
{
    public class ReservationEntity : Entity
    {
        public int ClientId { get; private set; }
        public int PackageId { get; private set; }

        public ReservationEntity(int id, int clientId, int packageId) : base(id)
        {
            ClientId = clientId;
            PackageId = packageId;
        }

    }
}
