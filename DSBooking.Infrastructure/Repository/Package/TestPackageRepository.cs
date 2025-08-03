using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;

namespace DSBooking.Infrastructure.Repository.Package
{
    public class TestPackageRepository : TestRepository<PackageEntity>, IPackageRepository
    {
        List<PackageEntity> _packages = new List<PackageEntity>();
        public TestPackageRepository()
        {
            //SeaPackageEntity package1 = new SeaPackageEntity();
            //package1.packetID = 1;
            //package1.PacketName = "Paket1";
            //package1.Price = 1000;
            //package1.Destination = "Krit";
            //package1.TransferType = "Avion";
            //package1.AccomodationType = "Hotel";

            //SeaPackageEntity package2 = new SeaPackageEntity();
            //package2.packetID = 2;
            //package2.PacketName = "Paket2";
            //package2.Price = 12000;
            //package2.Destination = "Kipar";
            //package2.TransferType = "Avion";
            //package2.AccomodationType = "Vila";
            //_packages.Add(package1);
            //_packages.Add(package2);
        }
    }
}
