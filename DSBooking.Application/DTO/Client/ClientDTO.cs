using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Application.DTO.Client
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
