using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Clients
{
    internal abstract class ClientFactory
    {
        public abstract Client createClient(object[] data);
    }
}
