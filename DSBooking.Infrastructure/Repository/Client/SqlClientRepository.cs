using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;
using DSBooking.Infrastructure.Mappers;

namespace DSBooking.Infrastructure.Repository.Client
{
    public class SqlClientRepository : Repository<ClientObject>, IClientRepository
    {
        public SqlClientRepository(ClientMapper mapper) : base(mapper) { }
        public void AddClient(ClientAddObject clientAddObject)
        {
            string sql = @"INSERT INTO Clients (firstname, lastname, passport_no, email_address, phone_no, date_of_birth)
                          VALUES (@FirstName, @LastName, @PassportNo, @Email, @PhoneNo, @DateOfBirth);";
            ExecuteNonQuery(sql, cmd =>
            {
                var p1 = cmd.CreateParameter(); p1.ParameterName = "@FirstName"; p1.Value = clientAddObject.FirstName; cmd.Parameters.Add(p1);
                var p2 = cmd.CreateParameter(); p2.ParameterName = "@LastName"; p2.Value = clientAddObject.LastName; cmd.Parameters.Add(p2);
                var p3 = cmd.CreateParameter(); p3.ParameterName = "@PassportNo"; p3.Value = clientAddObject.PassportNo; cmd.Parameters.Add(p3);
                var p4 = cmd.CreateParameter(); p4.ParameterName = "@Email"; p4.Value = clientAddObject.Email; cmd.Parameters.Add(p4);
                var p5 = cmd.CreateParameter(); p5.ParameterName = "@PhoneNo"; p5.Value = clientAddObject.PhoneNo; cmd.Parameters.Add(p5);
                var p6 = cmd.CreateParameter(); p6.ParameterName = "@DateOfBirth"; p6.Value = clientAddObject.DateOfBirth; cmd.Parameters.Add(p6);
            });
        }

        public ClientObject? Get(int id)
        {
            string sql = @"select id as ClientId, 
                                  firstname as FirstName, 
                                  lastname as LastName, 
                                  passport_no as PassportNumber, 
                                  email_address as Email, 
                                  phone_no as Phone, 
                                  date_of_birth as DateOfBirth 
                           from clients 
                           where id = @id;";
            var results = ExecuteQuery(sql, cmd =>
            {
                var param = cmd.CreateParameter();
                param.ParameterName = "@Id";
                param.Value = id;
                cmd.Parameters.Add(param);
            });
            Debug.WriteLine("Number of clients returned: " + results.Count());


            return results.Count > 0 ? results.FirstOrDefault() : null;
        }

        public IEnumerable<ClientObject> GetByFirstName(string filterString)
        {
            string sql = @"select id as ClientId, 
                                  firstname as FirstName, 
                                  lastname as LastName, 
                                  passport_no as PassportNumber, 
                                  email_address as Email, 
                                  phone_no as Phone, 
                                  date_of_birth as DateOfBirth 
                           from clients 
                           where firstname like @firstname;";

            var results = ExecuteQuery(sql, cmd =>
            {
                var param = cmd.CreateParameter();
                param.ParameterName = "@firstname";
                param.Value = "%" + filterString + "%";
                cmd.Parameters.Add(param);
            });
            Debug.WriteLine("Number of clients returned: " + results.Count());

            return results;
        }

        public IEnumerable<ClientObject> GetByLastName(string filterString)
        {
            string sql = @"select id as ClientId, 
                                  firstname as FirstName, 
                                  lastname as LastName, 
                                  passport_no as PassportNumber, 
                                  email_address as Email, 
                                  phone_no as Phone, 
                                  date_of_birth as DateOfBirth 
                           from clients 
                           where lastname like @lastname;";

            var results = ExecuteQuery(sql, cmd =>
            {
                var param = cmd.CreateParameter();
                param.ParameterName = "@lastname";
                param.Value = "%" + filterString + "%";
                cmd.Parameters.Add(param);
            });
            Debug.WriteLine("Number of clients returned: " + results.Count());

            return results;
        }

        public IEnumerable<ClientObject> GetByPassportNo(string filterString)
        {
            string sql = @"select id as ClientId, 
                                  firstname as FirstName, 
                                  lastname as LastName, 
                                  passport_no as PassportNumber, 
                                  email_address as Email, 
                                  phone_no as Phone, 
                                  date_of_birth as DateOfBirth 
                           from clients 
                           where passport_no like @passport_no;";

            var results = ExecuteQuery(sql, cmd =>
            {
                var param = cmd.CreateParameter();
                param.ParameterName = "@passport_no";
                param.Value = "%" + filterString + "%";
                cmd.Parameters.Add(param);
            });
            Debug.WriteLine("Number of clients returned: " + results.Count());
            return results;
        }

        public void RemoveClient(int clientId)
        {
            string sql = @"DELETE FROM Clients WHERE id = @Id;";

            ExecuteNonQuery(sql, cmd =>
            {
                var param = cmd.CreateParameter();
                param.ParameterName = "@Id";
                param.Value = clientId;
                cmd.Parameters.Add(param);
            });
        }
    }
}