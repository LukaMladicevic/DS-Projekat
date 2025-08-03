using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Exception
{
    public class EntityAlreadyExistsException : System.Exception
    {
        public EntityAlreadyExistsException(string message) : base(message) { }
    }
}
