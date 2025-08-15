using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Package;

namespace DSBooking.Presentation.View.Package
{
    public interface IPackageView : IView
    {
        event EventHandler<PackageObject>? OnSelectedPackage;

        void ShowPackages(IEnumerable<PackageObject> packages);
    }
}
