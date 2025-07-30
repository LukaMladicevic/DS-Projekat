using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DSBooking.Infrastructure
{
    internal class DbConnection
    {
        private static DbConnection _instance = new DbConnection();
        private IDbConnection _connection;

        internal static DbConnection Instance
        {
            get { return _instance; }
        }

        internal IDbConnection Connection 
        { 
            get { return _connection; }
        }

        private DbConnection()
        {
            _connection = new SqlConnection();
        }
    }
}
