using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DSBooking.Infrastructure.Factory
{
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        string _connectionString;

        public SqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;    
        }

        public IDbConnection Create()
        {
            return new SqlConnection();

            //return new SqlConnection(_connectionString);
        }
    }
}
