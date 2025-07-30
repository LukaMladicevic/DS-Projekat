using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Clients
{
    internal class BaseClient : Client
    {
        public BaseClient(int id, string name, string lastname, string passNo, DateTime date, string email, string phoneNo) : base(id, name, lastname, passNo, date, email, phoneNo)
        {}
        
    }
}
