using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DSBooking.Domain.Entity.Client
{
    public class ClientEntity : Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PassportNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public ClientEntity(int Id, string name, string lastName, string passportNumber, DateOnly dateOfBirth, string emailAddress, string phoneNumber) : base(Id)
        {
            Name = name;
            LastName = lastName;
            PassportNumber = passportNumber;
            DateOfBirth = dateOfBirth;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }
    }
}
