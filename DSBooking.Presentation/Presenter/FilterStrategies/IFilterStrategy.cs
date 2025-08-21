using DSBooking.Domain.Object.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter.FilterStrategies
{
    public interface IFilterStrategy
    {
        IEnumerable<ClientObject> Filter(IEnumerable<ClientObject> clients, string input);
    }
}
