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
                           left join AccomodationTypes a on p.accomodation_type_id = a.id
                           left join additionalactivites aa on p.additional_acttivities_id = aa.id
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
                           left join AccomodationTypes a on p.accomodation_type_id = a.id
                           left join additionalactivites aa on p.additional_acttivities_id = aa.id
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
                           left join AccomodationTypes a on p.accomodation_type_id = a.id
                           left join additionalactivites aa on p.additional_acttivities_id = aa.id
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