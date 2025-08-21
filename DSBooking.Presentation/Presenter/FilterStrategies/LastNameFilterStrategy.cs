using DSBooking.Domain.Object.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter.FilterStrategies
{
    public class LastNameFilterStrategy : IFilterStrategy
    {
        public IEnumerable<ClientObject> Filter(IEnumerable<ClientObject> clients, string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return clients;

            return clients.Where(c => c.LastName.Contains(input, StringComparison.OrdinalIgnoreCase));
        }
    }
}
