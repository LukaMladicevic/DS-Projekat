using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Object.Package
{
    public abstract class PackageBuilder<T> where T : PackageBuilder<T>
    {
        protected int id;
        protected string name;
        protected double price;
        protected string packageTypeName;

        public T WithId(int id)
        {
            this.id = id;
            return (T)this;
        }

        public T WithName(string name)
        {
            this.name = name;
            return (T)this;
        }

        public T WithPrice(double price)
        {
            this.price = price;
            return (T)this;
        }

        public T WithPackageTypeName(string packageTypeName)
        {
            this.packageTypeName = packageTypeName;
            return (T)this;
        }

        public abstract PackageObject Build();
    }
}
