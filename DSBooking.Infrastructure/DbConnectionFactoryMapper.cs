using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Infrastructure.Factory;

namespace DSBooking.Infrastructure
{
    public class DbConnectionFactoryMapper
    {
        string _connectionString;

        public DbConnectionFactoryMapper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnectionFactory Map()
        {
            return new SqlConnectionFactory(_connectionString);

            //// TODO
            //if (_connectionString.Contains("sqlite"))
            //    return new SqliteConnectionFactory(_connectionString);
            //else if (_connectionString.Contains("sql"))
            //    return new SqlConnectionFactory(_connectionString);
            //else 
            //    throw new NotImplementedException();
        }
    }
}
