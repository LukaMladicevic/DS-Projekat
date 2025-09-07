using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Reservation;
using DSBooking.Infrastructure.Mappers;

namespace DSBooking.Infrastructure.Repository.Reservation
{
    public class SqlReservationRepository : Repository<ReservationEntity>, IReservationRepository
    {
        public SqlReservationRepository(IMapper<ReservationEntity> mapper) : base(mapper) { }

        public int AddReservation(ReservationAddObject reservationAddObject)
        {
            throw new NotImplementedException();
        }

        public ReservationEntity? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationEntity> GetForClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public void RemoveReservation(int reservationId)
        {
            throw new NotImplementedException();
        }
    }
}
