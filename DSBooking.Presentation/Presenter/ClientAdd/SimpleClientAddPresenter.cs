using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application;
using DSBooking.Application.Service.Client;
using DSBooking.Domain.Error.Client;
using DSBooking.Domain.Object.Client;
using DSBooking.Presentation.View.Client;
using DSBooking.Presentation.View.ClientAdd;
using DSBooking.Presentation.View.Main;

namespace DSBooking.Presentation.Presenter.ClientAdd
{
    public class SimpleClientAddPresenter : ClientAddPresenter
    {
        public SimpleClientAddPresenter(IClientAddView clientView, IClientService clientService) : base(clientView, clientService)
        {
        }

        private void MarkAll(AddResult addResult)
        {
            View.MarkFirstName(ClientAddViewMarkOption.Correct);
            View.MarkLastName(ClientAddViewMarkOption.Correct);
            View.MarkEmail(ClientAddViewMarkOption.Correct);
            View.MarkPhoneNo(ClientAddViewMarkOption.Correct);
            View.MarkPassportNo(ClientAddViewMarkOption.Correct);
            View.MarkDateOfBirth(ClientAddViewMarkOption.Correct);

            foreach (var v in addResult.AddObjectErrors)
            {
                if (v is InvalidFirstNameError)
                    View.MarkFirstName(ClientAddViewMarkOption.Incorrect);
                else if (v is InvalidLastNameError)
                    View.MarkLastName(ClientAddViewMarkOption.Incorrect);
                else if (v is InvalidEmailError)
                    View.MarkEmail(ClientAddViewMarkOption.Incorrect);
                else if (v is InvalidPhoneNoError)
                    View.MarkPhoneNo(ClientAddViewMarkOption.Incorrect);
                else if (v is InvalidPassportNoError)
                    View.MarkPassportNo(ClientAddViewMarkOption.Incorrect);
            }
        }

        public override void DoOnClientAddSubmitted(ClientAddObject addObject)
        {
            AddResult addResult = Service.AddClient(addObject);

            MarkAll(addResult);
        }
    }
}
