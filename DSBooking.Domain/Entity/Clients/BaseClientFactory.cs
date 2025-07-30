using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Clients
{
    internal class BaseClientFactory : ClientFactory
    {
        Client c;

        public override Client createClient(object[] data)
        {
            return new BaseClient((int)data[0], (string)data[1], (string)data[2], (string)data[3], (DateTime)data[4], (string)data[5], (string)data[6]);
        }
    }
}
