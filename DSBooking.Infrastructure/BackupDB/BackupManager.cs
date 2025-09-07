using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.BackupDB
{
    public class BackupManager
    {
        IDbConnection _connection;
        DbConnection _dbInstance;
        string connString;
        IDatabaseBackup dbBackup;
        string backupPath;

        public BackupManager(string connString, string backupPath)
        {
            _dbInstance = DbConnection.Instance;
            _connection = _dbInstance.Connection;
            this.connString = connString;
            this.backupPath = backupPath;
        }

        public void Initialize()
        {
            if (_connection is SqliteConnection)
            {
                dbBackup = new SQLiteBackup((SqliteConnection)_connection);
            }
            else if (_connection is SqlConnection)
            {

                MySQLParser parser = new MySQLParser();

                parser.Parse(connString);

                dbBackup = new MySQLBackup(
                    user: parser.User,
                    password: parser.Password,
                    database: parser.Database
                    );
            }
            else
            {
                throw new NotImplementedException();
            }

            //Moze mapper da se napravi ali me mrzi
        }

        public void MakeBackup()
        {
            dbBackup.Backup(backupPath);
        }
    }
}
