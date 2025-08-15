using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Object.Client
{
    public class ClientAddObject
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime DateOfBirth { get; }
        string Email { get; }
        string PhoneNo { get; }

        public ClientAddObject(string firstName, string lastName, DateTime dateOfBirth, string email, string phoneNo)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNo = phoneNo;
        }
    }
}
