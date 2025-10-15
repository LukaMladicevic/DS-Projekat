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
                    return new SeasidePackageObject.Builder()
                        .WithId(id)
                        .WithName(name)
                        .WithPrice((double)price)
                        .WithPackageTypeName(type.ToString())
                        .WithDestinationName(GetString(record, "DestinationName"))
                        .WithTravelTypeName(GetString(record, "TransportTypeName"))
                        .WithAccommodationTypeName(GetString(record, "AccommodationTypeName"))
                        .Build();

                case PackageType.Mountain:
                    return new MountainPackageObject.Builder()
                        .WithId(id)
                        .WithName(name)
                        .WithPrice((double)price)
                        .WithPackageTypeName(type.ToString())
                        .WithDestinationName(GetString(record, "DestinationName"))
                        .WithTravelTypeName(GetString(record, "TransportTypeName")) 
                        .WithAccommodationTypeName(GetString(record, "AccommodationTypeName"))
                        .WithAdditionalActivities(GetString(record, "ActivityName")) 
                        .Build();

                case PackageType.Cruise:
                    return new CruisePackageObject.Builder()
                        .WithId(id)
                        .WithName(name)
                        .WithPrice((double)price)
                        .WithPackageTypeName(type.ToString())
                        .WithShipName(GetString(record, "ShipName"))
                        .WithRouteName(GetString(record, "RouteName"))
                        .WithDepartureDate(GetDateTime(record, "DepartureDate"))
                        .WithCabinTypeName(GetString(record, "CabinTypeName"))
                        .Build();

                case PackageType.Travel:
                    return new TravelPackageObject.Builder()
                        .WithId(id)
                        .WithName(name)
                        .WithPrice((double)price)
                        .WithPackageTypeName(type.ToString())
                        .WithDestinationName(GetString(record, "DestinationName"))
                        .WithTravelTypeName(GetString(record, "TransportTypeName")) // Assuming "TransportTypeName" is the DB field for TravelTypeName
                        .WithGuideName(GetString(record, "GuideName"))
                        .WithDuration(GetInt(record, "LengthInDays")) // Assuming "LengthInDays" is the DB field for Duration
                        .Build();

                default:
                    return new TravelPackageObject.Builder()
                        .WithId(0)
                        .WithName(string.Empty)
                        .WithPrice(0)
                        .WithPackageTypeName(string.Empty)
                        .WithDestinationName(string.Empty)
                        .WithTravelTypeName(string.Empty)
                        .WithGuideName(string.Empty)
                        .WithDuration(0)
                        .Build();
            }
        }
    }
}