using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Entity.Client
{
    public class ClientEntity
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string PassportNo { get; }
        public DateTime DateOfBirth { get; }
        public string Email { get; }
        public string PhoneNo { get; }

        public ClientEntity(int id, string firstName, string lastName, string passportNo, DateTime dateOfBirth, string email, string phoneNo)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PassportNo = passportNo;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNo = phoneNo;
        }
    }
}