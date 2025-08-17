using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Object.Client
{
    public class ClientAddObject
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string PassportNo { get; }
        public DateTime DateOfBirth { get; }
        public string Email { get; }
        public string PhoneNo { get; }

        public ClientAddObject(string firstName, string lastName, string passportNo, DateTime dateOfBirth, string email, string phoneNo)
        {
            FirstName = firstName;
            LastName = lastName;
            PassportNo = passportNo;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNo = phoneNo;
        }
    }
}
