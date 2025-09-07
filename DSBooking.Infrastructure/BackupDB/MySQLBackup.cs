using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.BackupDB
{
    internal class MySQLBackup : IDatabaseBackup
    {
        private string _user;
        private string _password;
        private string _database;

        public MySQLBackup(string user, string password, string database)
        {
            _user = user;
            _password = password;
            _database = database;
        }

        public void Backup(string backupPath)
        {
            var processInfo = new ProcessStartInfo("mysqldump",
            $"-u {_user} -p{_password} {_database}")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            var process = Process.Start(processInfo);
            string result = process.StandardOutput.ReadToEnd();
            File.WriteAllText(backupPath, result);
        }
    }
}
