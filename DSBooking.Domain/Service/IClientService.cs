﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Domain.Service
{
    public interface IClientService
    {
        IEnumerable<Client> GetClientsByName(string nameSubstring);
    }
}
