using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;

namespace DSBooking.Presentation.Presenter.Client
{
    public interface IFilterStrategy
    {
        IEnumerable<ClientObject> Filter(string filterString);
    }
}
