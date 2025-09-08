using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Infrastructure.Backup;

namespace DSBooking.Infrastructure.Factory
{
    // (ABSTRACT) FACTORY PATTERN
    public interface IDbInfrastructureFactory
    {
        IDbConnection CreateConnection();
        IDbBackupProvider CreateBackupProvider();
    }
}
