using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Client;
using DSBooking.Application.DTO.Package;

namespace DSBooking.Application.DTO.Reservation
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public ClientDTO? ClientDTO { get; set; }
        public PackageDTO? PackageDTO { get; set; }
    }
}
