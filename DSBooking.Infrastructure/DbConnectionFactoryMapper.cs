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
            // TODO
            return new SqlConnectionFactory(this._connectionString);
        }
    }
}
