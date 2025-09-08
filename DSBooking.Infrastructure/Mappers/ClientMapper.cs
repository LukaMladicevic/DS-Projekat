using DSBooking.Domain.Object.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Mappers
{
    public class ClientMapper : BaseMapper, IMapper<ClientObject>
    {
        public ClientObject Map(IDataRecord record)
        {
            return new ClientObject(
                GetInt(record, "ClientId"),
                GetString(record, "FirstName"),
                GetString(record, "LastName"),
                GetString(record, "PassportNumber"),
                GetDateTime(record, "DateOfBirth"),
                GetString(record, "Email"),
                GetString(record, "Phone")
            );
        }
    }
}
