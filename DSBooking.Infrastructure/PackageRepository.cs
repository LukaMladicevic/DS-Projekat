using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;
using DSBooking.Domain.Repository;

namespace DSBooking.Infrastructure
{
    public class PackageRepository : IPackageRepository
    {
        List<Package> _packages = new List<Package>();
        public PackageRepository() 
        {
            SeaPackage package1 = new SeaPackage();
            package1.packetID = 1;
            package1.PacketName = "Paket1";
            package1.Price = 1000;
            package1.Destination = "Krit";
            package1.TransferType = "Avion";
            package1.AccomodationType = "Hotel";

            SeaPackage package2 = new SeaPackage();
            package2.packetID = 2;
            package2.PacketName = "Paket2";
            package2.Price = 12000;
            package2.Destination = "Kipar";
            package2.TransferType = "Avion";
            package2.AccomodationType = "Vila";
            _packages.Add(package1);
            _packages.Add(package2);
        }

        public IEnumerable<Package> GetAllPackages()
        {
            return _packages;
        }
    }
}
