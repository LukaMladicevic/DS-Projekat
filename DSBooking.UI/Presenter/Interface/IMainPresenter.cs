using DSBooking.Domain.Entity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter
{
    public interface IMainPresenter
    {
        void selectClient(Client c);
    }
}
