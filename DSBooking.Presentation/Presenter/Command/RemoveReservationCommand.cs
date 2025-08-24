using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.Service.Reservation;
using DSBooking.Domain.Object.Reservation;

namespace DSBooking.Presentation.Presenter.Command
{
    internal class RemoveReservationCommand : ICommand
    {
        IReservationService _service;
        int? _id;

        ReservationAddObject _addObject;
        public RemoveReservationCommand(IReservationService service, int id)
        {
            _service = service;
            _id = id;

            ReservationObject reservation = _service.Get(id) ??
                throw new NullReferenceException();

            _addObject = new ReservationAddObject(reservation.DateOfReservation, reservation.ClientId, reservation.PackageId);
        }

        public void Execute()
        {
            if (_id != null)
            {
                _service.RemoveReservation((int)_id);
                _id = null;
            }
        }

        public void Undo()
        {
            if(_id == null)
            {
                _id = _service.AddReservation(_addObject);
            }
        }
    }
}
