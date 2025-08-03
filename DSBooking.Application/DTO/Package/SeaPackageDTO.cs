using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Application.DTO.Package
{
    public class SeaPackageDTO : PackageDTO
    {
        public string? Destination { get; set; }
        public string? TransportType { get; set; }
        public string? AccommodationType { get; set; }
    }
}
