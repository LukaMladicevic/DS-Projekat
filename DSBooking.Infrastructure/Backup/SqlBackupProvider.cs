using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Backup
{
    public class SqlBackupProvider : IDbBackupProvider
    {
        private readonly string _connectionString;
        private readonly string _defaultBackupFolder;

        public SqlBackupProvider(string connectionString, string? backupFolder = null)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            _defaultBackupFolder = backupFolder ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backups");
            if (!Directory.Exists(_defaultBackupFolder))
                Directory.CreateDirectory(_defaultBackupFolder);
        }

        public string Backup(string? backupFolder = null)
        {
            var destFolder = backupFolder ?? _defaultBackupFolder;
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);

            var map = ParseConnectionString(_connectionString);

            if (!map.TryGetValue("database", out var database) || string.IsNullOrWhiteSpace(database))
                throw new InvalidOperationException("MySQL connection string must contain 'Database'.");

            map.TryGetValue("server", out var server);
            map.TryGetValue("host", out var hostIfAny);
            server = string.IsNullOrEmpty(server) ? hostIfAny : server;
            if (string.IsNullOrEmpty(server)) server = "localhost";

            map.TryGetValue("port", out var port);
            if (string.IsNullOrEmpty(port)) port = "3306";

            string? user = null;
            if (!map.TryGetValue("user id", out user) &&
                !map.TryGetValue("uid", out user) &&
                !map.TryGetValue("userid", out user) &&
                !map.TryGetValue("user", out user))
            {
                throw new InvalidOperationException("MySQL connection string must contain user id (user/uid).");
            }

            map.TryGetValue("password", out var password);
            if (password == null)
            {
                password = string.Empty;
            }

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string backupFileName = Path.Combine(destFolder, $"mysql_backup_{database}_{timestamp}.sql");

            var args = $"-h {server} -P {port} -u{user} -p{password} {database}";

            var psi = new ProcessStartInfo
            {
                FileName = "mysqldump", 
                Arguments = args,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8
            };

            using var proc = Process.Start(psi) ?? throw new InvalidOperationException("Failed to start mysqldump process. Ensure mysqldump is installed and in PATH.");
            string stdout = proc.StandardOutput.ReadToEnd();
            string stderr = proc.StandardError.ReadToEnd();
            proc.WaitForExit();

            if (proc.ExitCode != 0)
            {
                throw new InvalidOperationException($"mysqldump failed (exit {proc.ExitCode}): {stderr}");
            }

            File.WriteAllText(backupFileName, stdout, Encoding.UTF8);
            Debug.WriteLine($"MySQL dump created: {backupFileName}");
            return Path.GetFullPath(backupFileName);
        }

        private static Dictionary<string, string> ParseConnectionString(string cs)
        {
            var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var parts = cs.Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var p in parts)
            {
                var i = p.IndexOf('=');
                if (i <= 0) continue;
                var k = p.Substring(0, i).Trim().ToLowerInvariant();
                var v = p.Substring(i + 1).Trim();
                dict[k] = v;
            }
            return dict;
        }
    }
}
