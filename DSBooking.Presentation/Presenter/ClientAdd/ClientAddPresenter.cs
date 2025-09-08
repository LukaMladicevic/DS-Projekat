using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.Service.Client;
using DSBooking.Domain.Object.Client;
using DSBooking.Presentation.View.Client;
using DSBooking.Presentation.View.ClientAdd;

namespace DSBooking.Presentation.Presenter.ClientAdd
{
    public abstract class ClientAddPresenter
    {
        protected IClientAddView View { get; private set; }
        protected IClientService Service { get; private set; }

        public ClientAddPresenter(IClientAddView clientView, IClientService clientService)
        {
            View = clientView;
            Service = clientService;
        }

        public abstract bool DoOnClientAddSubmitted(ClientAddObject addObject);
    }
}
