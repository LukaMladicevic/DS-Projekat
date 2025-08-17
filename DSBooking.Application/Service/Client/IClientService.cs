using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Client;

namespace DSBooking.Application.Service.Client
{
    public interface IClientService
    {
        IEnumerable<ClientObject> GetByName(string name);
        void AddClient(ClientAddObject client);
    }
}
