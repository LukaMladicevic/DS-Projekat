﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;

namespace DSBooking.Domain.Service
{
    public interface IPackageService
    {
        IEnumerable<Package> GetAllPackages();
        /// ???
    }
}
