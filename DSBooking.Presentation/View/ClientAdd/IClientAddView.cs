using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Presentation.View.ClientAdd
{
    public interface IClientAddView
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string PassportNo {  get; }
        public DateTime DateOfBirth { get; }
        public string Email { get; }
        public string PhoneNo { get; }

        event EventHandler<ClientAddObject>? ClientAddSubmitted;
    }
}
