using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Backup
{
    public class SqliteBackupProvider : IDbBackupProvider
    {
        private readonly string _dbFilePath;
        private readonly string _defaultBackupFolder;

        public SqliteBackupProvider(string dbFilePath, string? backupFolder = null)
        {
            _dbFilePath = dbFilePath ?? throw new ArgumentNullException(nameof(dbFilePath));
            _defaultBackupFolder = backupFolder ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backups");
            if (!Directory.Exists(_defaultBackupFolder))
                Directory.CreateDirectory(_defaultBackupFolder);
        }

        public string Backup(string? backupFolder = null)
        {
            var destFolder = backupFolder ?? _defaultBackupFolder;

            if (!File.Exists(_dbFilePath))
                throw new FileNotFoundException("SQLite database file not found.", _dbFilePath);

            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string backupFileName = Path.Combine(destFolder, $"sqlite_backup_{timestamp}.db");

            File.Copy(_dbFilePath, backupFileName, overwrite: false);

            Debug.WriteLine($"SQLite backup created: {backupFileName}");
            return Path.GetFullPath(backupFileName);
        }
    }
}
