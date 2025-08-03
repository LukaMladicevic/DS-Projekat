using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity;
using DSBooking.Infrastructure.Exception;

namespace DSBooking.Infrastructure.Repository
{
    public abstract class TestRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        List<TEntity> _entities = new List<TEntity>();

        public void Add(TEntity entity)
        {
            TEntity? existing = GetById(entity.Id);

            if(existing != null)
            {
                throw new EntityAlreadyExistsException("Cannot add entity - entity with same ID already exists.");  
            }

            _entities.Add(entity);
        }

        public void Delete(int Id)
        {
            TEntity? existing = GetById(Id);

            if (existing == null)
            {
                throw new InvalidEntityException("Cannot remove entity by ID - the entity doesn't exist.");
            }

            _entities.Remove(existing);
        }

        public IEnumerable<TEntity> GetAll()
        {
            List<TEntity> result = new List<TEntity>();

            foreach (TEntity entity in _entities)
            {
                result.Add(entity);
            }

            return result;
        }

        public TEntity? GetById(int id)
        {
            foreach(TEntity entity in _entities)
            {
                if(entity.Id == id) return entity;
            }

            return null;
        }

        public void Update(TEntity entity)
        {
            TEntity? existing = GetById(entity.Id);

            if (existing == null)
            {
                throw new EntityAlreadyExistsException("Cannot add entity - entity with same ID already exists.");
            }

            Delete(entity.Id);
            Add(entity);
        }
    }
}
