using DSBooking.Domain.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Service
{
    public interface IDomainService<T>
    {
        public IEnumerable<DomainError> CheckObject(T obj);
    }
}
