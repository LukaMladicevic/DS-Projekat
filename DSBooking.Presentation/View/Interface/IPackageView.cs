using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;

namespace DSBooking.Presentation.View.Interface
{
    public interface IPackageView : IView
    {
        event EventHandler<Package>? OnSelectedPackage;

        void ShowPackages(IEnumerable<Package> packages);
    }
}
