using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Reservation
{
    public class ReservationEntity
    {
        public int Id { get; }
        public DateTime DateOfReservation { get; }
        public ClientEntity Client { get; }          
        public PackageEntity Package { get; }       
        public ReservationEntity(int id, DateTime dateOfReservation, ClientEntity client, PackageEntity package)
        {
            Id = id;
            DateOfReservation = dateOfReservation;
            Client = client;
            Package = package;
        }
    }
}
