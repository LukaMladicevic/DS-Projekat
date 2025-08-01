using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;
using DSBooking.Presentation.View.Interface;

namespace DSBooking.Presentation.Presenter.Interface
{
    public interface IPackagePresenter : IPresenter
    {
        void ShowPackages();

        IEnumerable<Package> Packages { get; }
    }
}
