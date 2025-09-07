using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Package;

namespace DSBooking.Infrastructure.Repository.Package
{
    public class SqlPackageRepository : IPackageRepository
    {
        public PackageObject? Get(int id)
        {
            DbConnection.Instance.Connection.Open();

            DbConnection.Instance.Connection.Close();
            throw new NotImplementedException();
        }

        public IEnumerable<PackageObject> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PackageObject> GetAllAvailableForClient(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
