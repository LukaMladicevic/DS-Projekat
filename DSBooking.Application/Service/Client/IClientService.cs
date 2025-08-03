using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Client;
using DSBooking.Domain.Entity;

namespace DSBooking.Application.Service.Client
{
    public interface IClientService
    {
        IEnumerable<ClientDTO> GetClientsByName(string nameSubstring);
    }
}
