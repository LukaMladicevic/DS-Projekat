using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Repository;

namespace DSBooking.Domain.Service
{
    public class ReservationService : IReservationService
    {
        IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository) 
        {
            _reservationRepository = reservationRepository;
        }
    }
}
