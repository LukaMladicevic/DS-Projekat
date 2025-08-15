using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Object.Reservation
{
    public class ReservationAddObject
    {
        public DateTime DateOfReservation { get; }
        public int ClientId { get; }
        public int PackageId { get; }

        public ReservationAddObject(DateTime dateOfReservation, int clientId, int packageId)
        {
            DateOfReservation = dateOfReservation;
            ClientId = clientId;
            PackageId = packageId;
        }

    }
}
