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
    public class PhoneNoValidator : Validator<ClientAddObject>
    {
    protected override List<DomainError>? Handle(ClientAddObject obj)
        {
            var errors = new List<DomainError>();
            if (string.IsNullOrWhiteSpace(obj.PhoneNo))
                errors.Add(new InvalidPhoneNoError());
            return errors;
        }
    }
}
