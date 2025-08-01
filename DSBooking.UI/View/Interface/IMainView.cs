using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.View
{
    public interface IMainView
    {
        event EventHandler? OnClientAddViewOpen;

        // action - reserve or remove reservation
        event EventHandler<int>? OnActionChange; // invalid eventhandler param

        void ShowClientAddView();

        void ProcessActionChange(int action); // invalid param type
    }
}
