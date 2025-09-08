using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DSBooking.Domain.Error;
using DSBooking.Domain.Error.Client;
using DSBooking.Domain.Object.Client;

namespace DSBooking.Domain.Service
{
    public class DomainClientService
    {
        public DomainClientService() { }

        public IEnumerable<DomainError> CheckClientAddObject(ClientAddObject clientAddObject)
        {
            List<DomainError> errors = new List<DomainError>();

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (clientAddObject.FirstName == string.Empty)
                errors.Add(new InvalidFirstNameError());
            if(clientAddObject.LastName == string.Empty)
                errors.Add(new InvalidLastNameError());
            if((clientAddObject.Email == string.Empty) || !(Regex.IsMatch(clientAddObject.Email, emailPattern)))
                errors.Add(new InvalidEmailError());
            if(clientAddObject.PhoneNo == string.Empty)
                errors.Add(new InvalidPhoneNoError());
            if((clientAddObject.PassportNo == string.Empty) || (clientAddObject.PassportNo.Length != 13))
                errors.Add(new InvalidPassportNoError());

            return errors;
        }
    }
}
