using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Mappers
{
    public interface IMapper<T>
    {
        T Map(IDataRecord record);
    }
}
