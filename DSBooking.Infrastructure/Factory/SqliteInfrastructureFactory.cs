using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Infrastructure.Backup;
using Microsoft.Data.Sqlite;

namespace DSBooking.Infrastructure.Factory
{
    public class SqliteInfrastructureFactory : IDbInfrastructureFactory
    {
        string _connectionString;

        public SqliteInfrastructureFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbBackupProvider CreateBackupProvider()
        {
            throw new NotImplementedException();
        }

        public IDbConnection CreateConnection()
        {
            return new SqliteConnection(_connectionString);
        }
    }
}
