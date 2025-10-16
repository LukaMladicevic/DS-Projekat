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
            string dbPath = null!;
            var parts = _connectionString.Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var p in parts)
            {
                var idx = p.IndexOf('=');
                if (idx <= 0) continue;
                var key = p.Substring(0, idx).Trim().ToLowerInvariant();
                var val = p.Substring(idx + 1).Trim();
                if (key == "data source" || key == "datasource" || key == "filename")
                {
                    dbPath = val;
                    break;
                }
            }
            if (string.IsNullOrEmpty(dbPath))
                throw new InvalidOperationException("Could not find SQLite file path in connection string.");

            if (!Path.IsPathRooted(dbPath))
                dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbPath);

            return new SqliteBackupProvider(dbPath, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backups"));
        }

        public IDbConnection CreateConnection()
        {

            return new SqliteConnection(_connectionString);
        }
    }
}
