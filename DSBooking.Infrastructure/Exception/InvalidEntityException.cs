using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Exception
{
    public class InvalidEntityException : System.Exception
    {
        public InvalidEntityException(string message) : base(message) { }
    }
}
