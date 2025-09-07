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
        private IMapper<T> _mapper;

        public Repository(IMapper<T> mapper)
        {
            _mapper = mapper;
        }
    }
}
