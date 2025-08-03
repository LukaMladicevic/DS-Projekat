using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Application.DTO.Package
{
    public class CruisePackageDTO : PackageDTO
    {
        public string? ShipName { get; set; }
        public string? Route { get; set; }
        public DateTime? Departure { get; set; }
        public string? CabinType { get; set; }
    }
}
