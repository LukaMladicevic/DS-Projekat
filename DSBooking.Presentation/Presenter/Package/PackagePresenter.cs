using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.Service.Package;
using DSBooking.Domain.Object.Client;
using DSBooking.Domain.Object.Package;
using DSBooking.Presentation.View.Package;

namespace DSBooking.Presentation.Presenter.Package
{
    public abstract class PackagePresenter
    {
        public IEnumerable<PackageObject> Packages { get; protected set; } = Enumerable.Empty<PackageObject>();
        public abstract void ShowForClient(int clientId);
        public abstract void ShowAll();

        protected IPackageView View { get; private set; }
        protected IPackageService Service { get; private set; }

        public PackagePresenter(IPackageView view, IPackageService service)
        {
            View = view;
            Service = service;

            Packages = new List<PackageObject>();
        }
    }
}
