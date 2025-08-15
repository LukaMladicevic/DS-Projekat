using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Package;

namespace DSBooking.Presentation.Presenter.Package
{
    public interface IPackagePresenter : IPresenter
    {
        void ShowPackages();

        IEnumerable<PackageObject> Packages { get; }
    }
}
