using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Infrastructure.Repository.Reservation
{
    public class SqlReservationRepository : IReservationRepository
    {
        public void Add(ReservationEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReservationEntity? GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(ReservationEntity entity)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<ReservationEntity> GetReservationsForClient(int clientId)
        {
            throw new NotImplementedException();
        }

    }
}
