using DSBooking.Domain.Object.Client;
using DSBooking.Domain.Object.Package;
using DSBooking.Domain.Object.Reservation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Mappers
{
    public class ReservationMapper : BaseMapper, IMapper<ReservationObject>
    {
        private ClientMapper _clientMapper;
        private PackageMapper _packageMapper;

        public ReservationMapper(ClientMapper clientMapper, PackageMapper packageMapper)
        {
            _clientMapper = clientMapper;
            _packageMapper = packageMapper;
        }

        public ReservationObject Map(IDataRecord record)
        {
            ClientObject client = _clientMapper.Map(record);
            PackageObject package = _packageMapper.Map(record);

            return new ReservationObject(
                GetInt(record, "ReservationId"),
                GetDateTime(record, "ReservationDate"),
                client, 
                package
            );
        }
    }
}
