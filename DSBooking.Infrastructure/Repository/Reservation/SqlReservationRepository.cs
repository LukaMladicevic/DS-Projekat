using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Reservation;
using DSBooking.Infrastructure.Mappers;

namespace DSBooking.Infrastructure.Repository.Reservation
{
    public class SqlReservationRepository : Repository<ReservationObject>, IReservationRepository
    {
        public SqlReservationRepository(ReservationMapper mapper) : base(mapper) { }

        public void AddReservation(ReservationAddObject reservationAddObject)
        {
            throw new NotImplementedException();
        }

        public ReservationObject? Get(int id)
        {
            string sql = @"select
                                r.id                    as ReservationId,
                                r.date_of_reservation   as ReservationDate,

                                c.id                    as ClientId,
                                c.firstname             as FirstName,
                                c.lastname              as LastName,
                                c.date_of_birth         as DateOfBirth,
                                c.passport_no           as PassportNumber,
                                c.email_address         as Email,
                                c.phone_no              as Phone,

                                p.id                    as PackageId,
                                p.name                  as PackageName,
                                p.price                 as PackagePrice,
                                p.package_type          as PackageType,
                                d.name                  as DestinationName,
                                t.name                  as TransportTypeName,
                                a.name                  as AccommodationTypeName,
                                aa.name                 as ActivityName,
                                g.name                  as GuideName,
                                p.length_in_days        as LengthInDays,
                                s.name                  as ShipName,
                                ro.name                 as RouteName,
                                p.date_of_departure     as DepartureDate,
                                cbt.name                as CabinTypeName
                            from reservations r
                            left join clients c   ON r.client_id  = c.id
                            left join packages p  ON r.package_id = p.id
                            left join Destinations         d   ON p.destination_id         = d.id
                            left join TransportTypes       t   ON p.transport_type_id      = t.id
                            left join AccommodationTypes   a   ON p.accommodation_type_id  = a.id
                            left join AdditionalActivities aa  ON p.additional_activities_id = aa.id
                            left join Guides               g   ON p.guide_id               = g.id
                            left join Ships                s   ON p.ship_id                = s.id
                            left join Routes               ro  ON p.route_id               = ro.id
                            left join CabinTypes           cbt ON p.cabin_type_id          = cbt.id
                            where r.id = @ReservationId;";

            var results = ExecuteQuery(sql, cmd =>
            {
                var param = cmd.CreateParameter();
                param.ParameterName = "@ReservationId";
                param.Value = id;
                cmd.Parameters.Add(param);
            });

            return results.Count > 0 ? results.FirstOrDefault() : null;
        }

        public IEnumerable<ReservationObject> GetAll()
        {
            string sql = @"select
                                r.id                    as ReservationId,
                                r.date_of_reservation   as ReservationDate,

                                c.id                    as ClientId,
                                c.firstname             as FirstName,
                                c.lastname              as LastName,
                                c.date_of_birth         as DateOfBirth,
                                c.passport_no           as PassportNumber,
                                c.email_address         as Email,
                                c.phone_no              as Phone,

                                p.id                    as PackageId,
                                p.name                  as PackageName,
                                p.price                 as PackagePrice,
                                p.package_type          as PackageType,
                                d.name                  as DestinationName,
                                t.name                  as TransportTypeName,
                                a.name                  as AccommodationTypeName,
                                aa.name                 as ActivityName,
                                g.name                  as GuideName,
                                p.length_in_days        as LengthInDays,
                                s.name                  as ShipName,
                                ro.name                 as RouteName,
                                p.date_of_departure     as DepartureDate,
                                cbt.name                as CabinTypeName
                            FROM Reservations r
                            JOIN Clients c   ON r.client_id  = c.id
                            JOIN Packages p  ON r.package_id = p.id
                            LEFT JOIN Destinations         d   ON p.destination_id         = d.id
                            LEFT JOIN TransportTypes       t   ON p.transport_type_id      = t.id
                            LEFT JOIN AccommodationTypes   a   ON p.accommodation_type_id  = a.id
                            LEFT JOIN AdditionalActivities aa  ON p.additional_activities_id = aa.id
                            LEFT JOIN Guides               g   ON p.guide_id               = g.id
                            LEFT JOIN Ships                s   ON p.ship_id                = s.id
                            LEFT JOIN Routes               ro  ON p.route_id               = ro.id
                            LEFT JOIN CabinTypes           cbt ON p.cabin_type_id          = cbt.id;";

            return ExecuteQuery(sql);
        }

        public IEnumerable<ReservationObject> GetForClient(int clientId)
        {
            string sql = @"select
                                r.id                    as ReservationId,
                                r.date_of_reservation   as ReservationDate,

                                c.id                    as ClientId,
                                c.firstname             as FirstName,
                                c.lastname              as LastName,
                                c.date_of_birth         as DateOfBirth,
                                c.passport_no           as PassportNumber,
                                c.email_address         as Email,
                                c.phone_no              as Phone,

                                p.id                    as PackageId,
                                p.name                  as PackageName,
                                p.price                 as PackagePrice,
                                p.package_type          as PackageType,
                                d.name                  as DestinationName,
                                t.name                  as TransportTypeName,
                                a.name                  as AccommodationTypeName,
                                aa.name                 as ActivityName,
                                g.name                  as GuideName,
                                p.length_in_days        as LengthInDays,
                                s.name                  as ShipName,
                                ro.name                 as RouteName,
                                p.date_of_departure     as DepartureDate,
                                cbt.name                as CabinTypeName
                            FROM Reservations r
                            JOIN Clients c   ON r.client_id  = c.id
                            JOIN Packages p  ON r.package_id = p.id
                            LEFT JOIN Destinations         d   ON p.destination_id         = d.id
                            LEFT JOIN TransportTypes       t   ON p.transport_type_id      = t.id
                            LEFT JOIN AccommodationTypes   a   ON p.accommodation_type_id  = a.id
                            LEFT JOIN AdditionalActivities aa  ON p.additional_activities_id = aa.id
                            LEFT JOIN Guides               g   ON p.guide_id               = g.id
                            LEFT JOIN Ships                s   ON p.ship_id                = s.id
                            LEFT JOIN Routes               ro  ON p.route_id               = ro.id
                            LEFT JOIN CabinTypes           cbt ON p.cabin_type_id          = cbt.id
                            WHERE r.client_id = @ClientId;";

            return ExecuteQuery(sql, cmd =>
            {
                var param = cmd.CreateParameter();
                param.ParameterName = "@ClientId";
                param.Value = clientId;
                cmd.Parameters.Add(param);
            });

        }

        public void RemoveReservation(int reservationId)
        {
            string sql = @"delete from reservations
                           where id = @ReservationId";

            ExecuteNonQuery(sql, cmd =>
            {
                var param = cmd.CreateParameter();
                param.ParameterName = "@ReservationId";
                param.Value = reservationId;
                cmd.Parameters.Add(param);
            });
        }
    }
}