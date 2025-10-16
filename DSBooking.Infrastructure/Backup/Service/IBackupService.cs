using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Backup.Service
{
     public interface IBackupService
     { 
        string Backup(string? backupFolder = null);
     }
}
