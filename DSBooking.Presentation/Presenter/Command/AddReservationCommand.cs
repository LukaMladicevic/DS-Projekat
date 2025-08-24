using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.Service.Reservation;
using DSBooking.Domain.Object.Reservation;

namespace DSBooking.Presentation.Presenter.Command
{
    internal class AddReservationCommand : ICommand
    {
        IReservationService _reservationService;
        ReservationAddObject _reservationAddObject;

        int? _id;

        public AddReservationCommand(IReservationService reservationService, ReservationAddObject reservationAddObject)
        {
            _reservationService = reservationService;
            _reservationAddObject = reservationAddObject;

            _id = null;
        }

        public void Execute()
        {
            if (_id == null)
                _id = _reservationService.AddReservation(_reservationAddObject);
        }

        public void Undo()
        {
            if (_id != null)
                _reservationService.RemoveReservation((int)_id);
        }
    }
}
