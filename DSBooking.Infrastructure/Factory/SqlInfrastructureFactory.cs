using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Infrastructure.Backup;
using Microsoft.Data.SqlClient;

namespace DSBooking.Infrastructure.Factory
{
    public class SqlInfrastructureFactory : IDbInfrastructureFactory
    {
        string _connectionString;

        public SqlInfrastructureFactory(string connectionString)
        {
            _connectionString = connectionString;    
        }

        public IDbBackupProvider CreateBackupProvider()
        {
            return new SqlBackupProvider();
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection();

            //return new SqlConnection(_connectionString);
        }
    }
}
