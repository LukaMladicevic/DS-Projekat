using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace DSBooking.Infrastructure.Factory
{
    public class SqliteConnectionFactory : IDbConnectionFactory
    {
        string _connectionString;

        public SqliteConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection Create()
        {
            return new SqliteConnection(_connectionString);
        }
    }
}
