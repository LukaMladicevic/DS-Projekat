using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }

        public Entity(int Id)
        {
            this.Id = Id;            
        }

        public override bool Equals(object? obj) => (obj is Entity) && (((IEntity)obj).Id == this.Id);
        public override int GetHashCode() => base.GetHashCode();
    }
}
