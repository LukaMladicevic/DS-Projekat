using DSBooking.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Repository
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        TEntity? GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        //IEntity MapRecord(IDataRecord record);
        //protected IEnumerable<IEntity> ToList(IDbCommand command);
    }
}
