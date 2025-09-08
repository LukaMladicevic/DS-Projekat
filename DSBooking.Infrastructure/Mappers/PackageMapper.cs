using DSBooking.Domain.Object.Package;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Mappers
{
    public enum PackageType
    {
        Seaside = 1,
        Mountain = 2,
        Travel = 3,
        Cruise = 4
    }
    public class PackageMapper : BaseMapper, IMapper<PackageObject>
    {
        public PackageObject Map(IDataRecord record)
        {
            var type = (PackageType)GetInt(record, "PackageType");
            var id = GetInt(record, "PackageId");
            var name = GetString(record, "PackageName");
            var price = GetDecimal(record, "PackagePrice");

            switch (type)
            {
                case PackageType.Seaside:
                    return new SeasidePackageObject(
                        id,
                        name,
                        (double)price,
                        type.ToString(),
                        GetString(record, "DestinationName"),
                        GetString(record, "TransportTypeName"),
                        GetString(record, "AccommodationTypeName")
                    );

                case PackageType.Mountain:
                    return new MountainPackageObject(
                        id,
                        name,
                        (double)price,
                        type.ToString(),
                        GetString(record, "DestinationName"),
                        GetString(record, "TransportTypeName"),
                        GetString(record, "AccommodationTypeName"),
                        GetString(record, "ActivityName")
                    );

                case PackageType.Cruise:
                    return new CruisePackageObject(
                        id,
                        name,
                        (double)price,
                        type.ToString(),
                        GetString(record, "ShipName"),
                        GetString(record, "RouteName"),
                        GetDateTime(record, "DepartureDate"),
                        GetString(record, "CabinTypeName")
                    );

                case PackageType.Travel:
                    return new TravelPackageObject(
                        id,
                        name,
                        (double)price,
                        type.ToString(),
                        GetString(record, "DestinationName"),
                        GetString(record, "TransportTypeName"),
                        GetString(record, "GuideName"),
                        GetInt(record, "LengthInDays")
                    );

                default:
                    return new TravelPackageObject(0, string.Empty, 0, string.Empty, string.Empty, string.Empty, string.Empty, 0);
            }
        }
    }
}