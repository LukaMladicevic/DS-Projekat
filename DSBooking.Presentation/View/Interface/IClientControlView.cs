using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.View.Interface
{
    public interface IClientControlView : IClientView
    {
        Control Control { get; }
    }
}
