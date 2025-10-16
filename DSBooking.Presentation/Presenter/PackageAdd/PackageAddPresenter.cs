using DSBooking.Application.Service.Package;
using DSBooking.Presentation.View.PackageAdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.Presenter.PackageAdd
{
    public abstract class PackageAddPresenter
    {
        protected IPackageAddView View { get; private set; }
        protected IPackageService Service { get; private set; }

        public PackageAddPresenter(IPackageAddView view, IPackageService service)
        {
            View = view ?? throw new ArgumentNullException(nameof(view));
            Service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public abstract bool DoOnPackageAddSubmitted();
    }
}
