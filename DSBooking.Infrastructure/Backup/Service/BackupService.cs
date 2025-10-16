using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Backup.Service
{
    public class BackupService : IBackupService
    {
        public string Backup(string? backupFolder = null)
        {
            var provider = DSBooking.Infrastructure.DbConnection.Instance.BackupProvider;
            var path = provider.Backup(backupFolder);
            return path;
        }
    }
}
