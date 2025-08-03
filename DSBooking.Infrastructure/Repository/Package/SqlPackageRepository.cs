using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;

namespace DSBooking.Infrastructure.Repository.Package
{
    public class SqlPackageRepository : IPackageRepository
    {
        public void Add(PackageEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PackageEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public PackageEntity? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PackageEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
