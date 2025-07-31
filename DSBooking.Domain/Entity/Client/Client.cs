using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Client
{
    public class Client
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string PassNo { get; private set; }
        public DateOnly Date { get; private set; }
        public string Email { get; private set; }
        public string PhoneNo { get; private set; }

        public Client(int id, string name, string lastName, string passNo, DateOnly date, string email, string phoneNo)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            PassNo = passNo;
            Date = date;
            Email = email;
            PhoneNo = phoneNo;
        }
    }
}
