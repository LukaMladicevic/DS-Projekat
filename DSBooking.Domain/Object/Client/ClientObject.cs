using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Object.Client
{
    public class ClientObject
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }
        public string Email { get; }
        public string PhoneNo { get; }

        public ClientObject(int id, string firstName, string lastName, DateTime dateOfBirth, string email, string phoneNo)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNo = phoneNo;
        }
    }
}