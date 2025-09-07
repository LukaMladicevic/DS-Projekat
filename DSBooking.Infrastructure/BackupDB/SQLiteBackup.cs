using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.BackupDB
{
    internal class SQLiteBackup : IDatabaseBackup
    {
        SqliteConnection _connection;

        public SQLiteBackup(SqliteConnection connection)
        {
            _connection = connection;
        }

        public void Backup(string backupPath)
        {
            _connection.Open();

            var command = new SqliteCommand($"VACUUM INTO '{backupPath}'", _connection);

            command.ExecuteNonQuery();

            _connection.Close();

        }
    }
}
