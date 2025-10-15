using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Object.Package
{
    public abstract class PackageObject
    {
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }
        public string PackageTypeName { get; }

        protected PackageObject(int id, string name, double price, string packageTypeName)
        {
            Id = id;
            Name = name;
            Price = price;
            PackageTypeName = packageTypeName;
        }
    }
}