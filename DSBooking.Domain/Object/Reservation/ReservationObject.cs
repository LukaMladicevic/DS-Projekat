using DSBooking.Domain.Object.Client;
using DSBooking.Domain.Object.Package;
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
        public ClientObject Client { get; }          
        public PackageObject Package { get; }       
        public ReservationObject(int id, DateTime dateOfReservation, ClientObject client, PackageObject package)
        {
            Id = id;
            DateOfReservation = dateOfReservation;
            Client = client;
            Package = package;
        }
    }
}
