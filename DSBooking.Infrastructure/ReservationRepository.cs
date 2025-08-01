using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Reservation;
using DSBooking.Domain.Repository;

namespace DSBooking.Infrastructure
{
    public class ReservationRepository : IReservationRepository
    {
        List<Reservation> reservations = new List<Reservation>();
        public ReservationRepository() 
        {
            reservations.Add(new Reservation(1, 1, 1));
            reservations.Add(new Reservation(2, 1, 2));
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return reservations;
        }

        public IEnumerable<Reservation> GetReservationsForClient(Client c)
        {
            return (from r in reservations
                    where r.ClientId == c.Id
                    select r).ToList();
        }
    }
}
