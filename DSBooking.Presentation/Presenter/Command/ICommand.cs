using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter.Command
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
