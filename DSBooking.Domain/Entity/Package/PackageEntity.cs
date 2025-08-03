using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Package
{
    public abstract class PackageEntity : Entity
    {
        public string Name { get; set; }
        public double Price { get; set; }

        //public Destination Destination;

        public PackageEntity(int Id, string name, double price) : base(Id)
        {
            Name = name;
            Price = price;
        }

    }
}
