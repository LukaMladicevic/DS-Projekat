using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Infrastructure.Factory;
using Microsoft.Data.SqlClient;

namespace DSBooking.Infrastructure
{
    public class DbConnection
    {
        private static DbConnection? _instance = null;
        private IDbConnection _connection;

        public static void Initialize(IDbConnectionFactory factory)
        {
            IDbConnection connection = factory.Create();
            _instance = new DbConnection(connection);
        }
        
        internal static DbConnection Instance
        {
            get { return _instance ?? throw new DbConnectionNotInitializedException(); }
        }

        internal IDbConnection Connection
        {
            // using (connection = DbConnection.Connection)
            // {
            //   
            // } ???
            get { return _connection; }
        }

        private DbConnection(IDbConnection connection)
        {
            _connection = connection;
        }
    }

}
