using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Error;
using DSBooking.Domain.Object.Reservation;
using DSBooking.Infrastructure.Repository.Reservation;

namespace DSBooking.Application.Service.Reservation
{
    public class ReservationService : IReservationService
    {
        IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public IEnumerable<ReservationObject> GetAll()
        {
            return _reservationRepository.GetAll();
        }

        public IEnumerable<ReservationObject> GetForClient(int clientId)
        {
            Debug.WriteLine($"[RES-SERVICE] Entering GetForClient({clientId}) - instance={this.GetHashCode()} repoType={_reservationRepository?.GetType().FullName}");
            var reservations = _reservationRepository.GetForClient(clientId)?.ToList() ?? new List<ReservationObject>();

            var sb = new StringBuilder();
            sb.AppendLine($"ClientId: {clientId}");
            foreach (var reservation in reservations)
            {
                sb.AppendLine($"Reservation ID: {reservation.Id}");
                sb.AppendLine($"Client: {reservation.Client?.FirstName} {reservation.Client?.LastName}");
                sb.AppendLine($"Package: {reservation.Package?.Name}");
                sb.AppendLine($"Type: {reservation.Package?.PackageTypeName}");
                sb.AppendLine(new string('-', 40));
            }

            Debug.WriteLine(sb.ToString());
            return _reservationRepository.GetForClient(clientId);
        }

        public AddResult AddReservation(ReservationAddObject reservationAddObject)
        {
            _reservationRepository.AddReservation(reservationAddObject);
            return new AddResult(Enumerable.Empty<DomainError>());
        }

        public void RemoveReservation(int reservationId)
        {
            _reservationRepository.RemoveReservation(reservationId);
        }

        public ReservationObject? Get(int id)
        {
            return _reservationRepository.Get(id);
        }
    }
}
