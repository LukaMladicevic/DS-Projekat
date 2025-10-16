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
            DateTime date;
            try
            {
                date = GetDateTime(record, "DateOfBirth");
            }
            catch(Exception)
            {
                date = DateTime.MinValue;
            }
            return new ClientObject(
                GetInt(record, "ClientId"),
                GetString(record, "FirstName"),
                GetString(record, "LastName"),
                GetString(record, "PassportNumber"),
                date,
                GetString(record, "Email"),
                GetString(record, "Phone")
            );
        }
    }
}
