using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Reservation;
using DSBooking.Infrastructure.Mappers;

namespace DSBooking.Infrastructure.Repository.Reservation
{
    public class SqlReservationRepository : Repository<ReservationObject>, IReservationRepository
    {
        public SqlReservationRepository(IDbConnection dbConnection, IMapper<ReservationObject> mapper) : base(dbConnection, mapper) { }

        public int AddReservation(ReservationAddObject reservationAddObject)
        {
            throw new NotImplementedException();
        }

        public ReservationObject? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationObject> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationObject> GetForClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public void RemoveReservation(int reservationId)
        {
            throw new NotImplementedException();
        }
    }
}
