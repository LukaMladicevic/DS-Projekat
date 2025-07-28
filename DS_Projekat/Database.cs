using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DSBooking
{
    public class Database
    {
        private static Database instance = null;
        private IDbConnection connection;

        public static Database Instance
        {
            get
            {
                if (instance == null)
                    instance = new Database();

                return instance;
            }
        }

        private Database()
        {
            /*
             * ako je sql, onda
             * connection = new SqlConnection();
             * else
             * connection = new SqliteConneciton();
             * 
             * 
             * 
             * 
             */

            connection = new SqlConnection("CONNECTION_STRING");

        }

        public IDataReader query(String query)
        {
            connection.Open();

            IDbCommand command = connection.CreateCommand();
            command.CommandText = query;
            IDataReader reader = command.ExecuteReader();

            connection.Close();

            return reader;
        }
    }
}