using DSBooking.Infrastructure.Factory;
using DSBooking.Infrastructure.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Repository
{
    public abstract class Repository<T>
    {
        protected IMapper<T> Mapper { get; private set; }

        public Repository(IMapper<T> mapper)
        {
            Mapper = mapper;
        }
    }
}
