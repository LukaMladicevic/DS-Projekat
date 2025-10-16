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
    public class PassportNoLengthValidator : Validator<ClientAddObject>
    {
        protected override List<DomainError>? Handle(ClientAddObject obj)
        {
            var errors = new List<DomainError>();
            if (string.IsNullOrWhiteSpace(obj.PassportNo) || obj.PassportNo.Length != 13)
                errors.Add(new InvalidPassportNoError());
            return errors;
        }
    }
}
