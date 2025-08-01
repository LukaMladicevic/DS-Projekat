using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Repository;
using DSBooking.Presentation.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter
{
    public class MainPresenter : IMainPresenter
    {
        IMainView _view;
        IClientControlView _clientControlView;
        IReservationView _reservationView;
        IPackageView _packageView;

        IClientRepository _clientRepository;
        IReservationRepository _reservationRepository;
        IPackageRepository _packageRepository;

        public MainPresenter()
        {
            
        }
        public void selectClient(Client c)
        {
         
        }
    }
}
