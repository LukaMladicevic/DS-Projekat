using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;

namespace DSBooking.Presentation.View.ClientAdd
{
    public enum ClientAddViewMarkOption { Correct, Incorrect }
    public interface IClientAddView
    {
        string FirstName { get; }
        string LastName { get; }
        string PassportNo {  get; }
        DateTime DateOfBirth { get; }
        string Email { get; }
        string PhoneNo { get; }

        void MarkFirstName(ClientAddViewMarkOption markOption);
        void MarkLastName(ClientAddViewMarkOption markOption);
        void MarkPassportNo(ClientAddViewMarkOption markOption);
        void MarkDateOfBirth(ClientAddViewMarkOption markOption);
        void MarkEmail(ClientAddViewMarkOption markOption);
        void MarkPhoneNo(ClientAddViewMarkOption markOption);

        event EventHandler<ClientAddObject>? ClientAddSubmitted;
        event EventHandler? ClientAddCancelled;
    }
}
