using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Package;
using DSBooking.Infrastructure.Mappers;

namespace DSBooking.Infrastructure.Repository.Package
{
    public class SqlPackageRepository : Repository<PackageObject>, IPackageRepository
    {
        public SqlPackageRepository(PackageMapper Mapper) : base(Mapper) { }

        public int AddPackage(PackageObject package)
        {
            var columns = new List<string> { "name", "price", "package_type" };
            var values = new List<string> { "@Name", "@Price", "@PackageType" };

            var paramPairs = new List<(string name, object value)>();
            paramPairs.Add(("@Name", package.Name));
            paramPairs.Add(("@Price", package.Price));
            paramPairs.Add(("@PackageType", MapPackageType(package)));

            if (package is SeasidePackageObject seaside)
            {
                columns.Add("destination_id");
                values.Add("(SELECT id FROM Destinations WHERE name = @DestinationName)");
                paramPairs.Add(("@DestinationName", seaside.DestinationName ?? (object)DBNull.Value));

                columns.Add("transport_type_id");
                values.Add("(SELECT id FROM TransportTypes WHERE name = @TransportTypeName)");
                paramPairs.Add(("@TransportTypeName", seaside.TravelTypeName ?? (object)DBNull.Value));

                columns.Add("accommodation_type_id");
                values.Add("(SELECT id FROM AccommodationTypes WHERE name = @AccommodationTypeName)");
                paramPairs.Add(("@AccommodationTypeName", seaside.AccommodationTypeName ?? (object)DBNull.Value));
            }
            else if (package is TravelPackageObject travel)
            {
                columns.Add("destination_id");
                values.Add("(SELECT id FROM Destinations WHERE name = @DestinationName)");
                paramPairs.Add(("@DestinationName", travel.DestinationName ?? (object)DBNull.Value));

                columns.Add("transport_type_id");
                values.Add("(SELECT id FROM TransportTypes WHERE name = @TransportTypeName)");
                paramPairs.Add(("@TransportTypeName", travel.TravelTypeName ?? (object)DBNull.Value));

                columns.Add("guide_id");
                values.Add("(SELECT id FROM Guides WHERE name = @GuideName)");
                paramPairs.Add(("@GuideName", travel.GuideName ?? (object)DBNull.Value));

                columns.Add("length_in_days");
                values.Add("@LengthInDays");
                paramPairs.Add(("@LengthInDays", travel.Duration));
            }
            else if (package is CruisePackageObject cruise)
            {
                columns.Add("ship_id");
                values.Add("(SELECT id FROM Ships WHERE name = @ShipName)");
                paramPairs.Add(("@ShipName", cruise.ShipName ?? (object)DBNull.Value));

                columns.Add("route_id");
                values.Add("(SELECT id FROM Routes WHERE name = @RouteName)");
                paramPairs.Add(("@RouteName", cruise.RouteName ?? (object)DBNull.Value));

                columns.Add("date_of_departure");
                values.Add("@DepartureDate");
                paramPairs.Add(("@DepartureDate", cruise.DepartureDate));

                columns.Add("cabin_type_id");
                values.Add("(SELECT id FROM CabinTypes WHERE name = @CabinTypeName)");
                paramPairs.Add(("@CabinTypeName", cruise.CabinTypeName ?? (object)DBNull.Value));
            }
            else if (package is MountainPackageObject mountain)
            {
                columns.Add("destination_id");
                values.Add("(SELECT id FROM Destinations WHERE name = @DestinationName)");
                paramPairs.Add(("@DestinationName", mountain.DestinationName ?? (object)DBNull.Value));

                columns.Add("transport_type_id");
                values.Add("(SELECT id FROM TransportTypes WHERE name = @TransportTypeName)");
                paramPairs.Add(("@TransportTypeName", mountain.TravelTypeName ?? (object)DBNull.Value));

                columns.Add("accommodation_type_id");
                values.Add("(SELECT id FROM AccommodationTypes WHERE name = @AccommodationTypeName)");
                paramPairs.Add(("@AccommodationTypeName", mountain.AccommodationTypeName ?? (object)DBNull.Value));

                columns.Add("additional_activities_id");
                values.Add("(SELECT id FROM AdditionalActivities WHERE name = @AdditionalActivitiesName)");
                paramPairs.Add(("@AdditionalActivitiesName", mountain.AdditionalActivities ?? (object)DBNull.Value));
            }
            else
            {
                throw new ArgumentException("Unsupported package subtype");
            }

            var sql = $"INSERT INTO Packages ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)});";

            var affected = ExecuteNonQuery(sql, cmd =>
            {
                foreach (var (name, value) in paramPairs)
                {
                    var p = cmd.CreateParameter();
                    p.ParameterName = name;
                    p.Value = value ?? DBNull.Value;
                    cmd.Parameters.Add(p);
                }
            });

            return affected;
        }

        private int MapPackageType(PackageObject package)
        {
            if (package is SeasidePackageObject) return (int)PackageType.Seaside;
            if (package is TravelPackageObject) return (int)PackageType.Travel;
            if (package is CruisePackageObject) return (int)PackageType.Cruise;
            if (package is MountainPackageObject) return (int)PackageType.Mountain;
            throw new ArgumentException("Unknown package subtype");
        }

        public PackageObject? Get(int id)
        {
            string sql = @"select p.id as PackageId,
                           p.name as PackageName,
                           p.price as PackagePrice,
                           p.package_type as PackageType,
                           d.name as DestinationName,
                           t.name as TransportTypeName,
                           a.name as AccommodationTypeName,
                           aa.name as ActivityName,
                           g.name as GuideName,
                           p.length_in_days as LengthInDays,
                           s.name as ShipName,
                           r.name as RouteName,
                           p.date_of_departure as DepartureDate,
                           c.name as CabinTypeName
                           from packages p join destinations d on p.destination_id = d.id
                           left join TransportTypes t on p.transport_type_id = t.id
                           left join AccommodationTypes a on p.accommodation_type_id = a.id
                           left join AdditionalActivities aa on p.additional_activities_id = aa.id
                           left join Guides g on p.guide_id = g.id
                           left join Ships s on p.ship_id = s.id
                           left join Routes r on p.route_id = r.id
                           left join CabinTypes c on p.cabin_type_id = c.id
                           where p.id = @id";

            var results = ExecuteQuery(sql, cmd =>
            {
                var param = cmd.CreateParameter();
                param.ParameterName = "@id";
                param.Value = id;
                cmd.Parameters.Add(param);
            });
            return results.Count > 0 ? results.FirstOrDefault() : null;

        }

        public IEnumerable<PackageObject> GetAll()
        {
            string sql = @"select p.id as PackageId,
                           p.name as PackageName,
                           p.price as PackagePrice,
                           p.package_type as PackageType,
                           d.name as DestinationName,
                           t.name as TransportTypeName,
                           a.name as AccommodationTypeName,
                           aa.name as ActivityName,
                           g.name as GuideName,
                           p.length_in_days as LengthInDays,
                           s.name as ShipName,
                           r.name as RouteName,
                           p.date_of_departure as DepartureDate,
                           c.name as CabinTypeName
                           from packages p join destinations d on p.destination_id = d.id
                           left join TransportTypes t on p.transport_type_id = t.id
                           left join AccommodationTypes a on p.accommodation_type_id = a.id
                           left join AdditionalActivities aa on p.additional_activities_id = aa.id
                           left join Guides g on p.guide_id = g.id
                           left join Ships s on p.ship_id = s.id
                           left join Routes r on p.route_id = r.id
                           left join CabinTypes c on p.cabin_type_id = c.id";

            return ExecuteQuery(sql);
        }

        public IEnumerable<PackageObject> GetAllAvailableForClient(int clientId)
        {
            string sql = @"select p.id as PackageId,
                           p.name as PackageName,
                           p.price as PackagePrice,
                           p.package_type as PackageType,
                           d.name as DestinationName,
                           t.name as TransportTypeName,
                           a.name as AccommodationTypeName,
                           aa.name as ActivityName,
                           g.name as GuideName,
                           p.length_in_days as LengthInDays,
                           s.name as ShipName,
                           r.name as RouteName,
                           p.date_of_departure as DepartureDate,
                           c.name as CabinTypeName
                           from packages p join destinations d on p.destination_id = d.id
                           left join TransportTypes t on p.transport_type_id = t.id
                           left join AccommodationTypes a on p.accommodation_type_id = a.id
                           left join AdditionalActivities aa on p.additional_activities_id = aa.id
                           left join Guides g on p.guide_id = g.id
                           left join Ships s on p.ship_id = s.id
                           left join Routes r on p.route_id = r.id
                           left join CabinTypes c on p.cabin_type_id = c.id
                           where p.id not in (
                                select r.package_id
                                from Reservations r
                                where r.client_id = @ClientId
                           );";

            return ExecuteQuery(sql, cmd =>
            {
                var param = cmd.CreateParameter();
                param.ParameterName = "@ClientId";
                param.Value = clientId;
                cmd.Parameters.Add(param);
            });
        }
    }
}