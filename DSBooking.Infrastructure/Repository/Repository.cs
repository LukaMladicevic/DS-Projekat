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
        private IDbConnection _dbConnection;
        private IMapper<T> _mapper;

        public Repository(IDbConnection dbConnection, IMapper<T> mapper)
        {
            _dbConnection = dbConnection;
            _mapper = mapper;
        }
    }
}
