using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Package;
using DSBooking.Domain.Entity.Reservation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Mappers
{
    public class ReservationMapper : BaseMapper, IMapper<ReservationEntity>
    {
        private IMapper<ClientEntity> _clientMapper;
        private IMapper<PackageEntity> _packageMapper;

        public ReservationMapper(IMapper<ClientEntity> clientMapper, IMapper<PackageEntity> packageMapper)
        {
            _clientMapper = clientMapper;
            _packageMapper = packageMapper;
        }

        public ReservationEntity Map(IDataRecord record)
        {
            ClientEntity client = _clientMapper.Map(record);
            PackageEntity package = _packageMapper.Map(record);

            return new ReservationEntity(
                GetInt(record, "ReservationId"),
                GetDateTime(record, "ReservationDate"),
                client, 
                package
            );
        }
    }
}
