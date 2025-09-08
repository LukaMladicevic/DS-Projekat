using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Infrastructure.Factory;

namespace DSBooking.Infrastructure
{
    public class DbInfrastructureMapper
    {
        string _connectionString;

        public DbInfrastructureMapper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbInfrastructureFactory Map()
        {
            if (string.IsNullOrWhiteSpace(_connectionString))
                throw new ArgumentException("Connection string is null or empty.");

            string connLower = _connectionString.ToLowerInvariant();

            if (connLower.Contains("data source=")) // sqlite
                return new SqliteInfrastructureFactory(_connectionString);

            if (connLower.Contains("server=") || connLower.Contains("database=")) // sql server
                return new SqlInfrastructureFactory(_connectionString);

            throw new NotSupportedException("Unknown database provider in connection string.");
        }
    }
}
