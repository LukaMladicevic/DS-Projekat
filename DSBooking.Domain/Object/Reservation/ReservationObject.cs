using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Object.Reservation
{
    public class ReservationObject
    {
        public int Id { get; }
        public DateTime DateOfReservation { get; }
        public int ClientId { get; }
        public string ClientName { get; }
        public int PackageId { get; }
        public string PackageName { get; }
        public double PackagePrice { get; }

        public ReservationObject(int id, DateTime dateOfReservation, int clientId, string clientName, int packageId, string packageName, double packagePrice)
        {
            Id = id;
            DateOfReservation = dateOfReservation;
            ClientId = clientId;
            ClientName = clientName;
            PackageId = packageId;
            PackageName = packageName;
            PackagePrice = packagePrice;
        }
    }
}
