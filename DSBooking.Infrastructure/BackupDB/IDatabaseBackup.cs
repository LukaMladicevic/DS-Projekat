using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.BackupDB
{
    internal interface IDatabaseBackup
    {
        public void Backup(string backupPath);
    }
}
