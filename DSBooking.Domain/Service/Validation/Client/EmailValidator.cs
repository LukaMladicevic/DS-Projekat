using DSBooking.Domain.Error;
using DSBooking.Domain.Error.Client;
using DSBooking.Domain.Object.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Service.Validation.Client
{
    public class EmailValidator : Validator<ClientAddObject>
    {
        protected override List<DomainError>? Handle(ClientAddObject obj)
        {
            var errors = new List<DomainError>();
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (string.IsNullOrWhiteSpace(obj.Email) || !System.Text.RegularExpressions.Regex.IsMatch(obj.Email, emailPattern))
                errors.Add(new InvalidEmailError());
            return errors;
        }
    }
}
