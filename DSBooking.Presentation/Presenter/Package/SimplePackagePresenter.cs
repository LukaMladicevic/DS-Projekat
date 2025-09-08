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
    public class SimplePackagePresenter : PackagePresenter
    {
        public SimplePackagePresenter(IPackageView view, IPackageService service) : base(view, service)
        {
        }

        public override void ShowAll()
        {
            IEnumerable<PackageObject> packages = Service.GetAll();

            Packages = packages;

            View.ShowPackages(packages);
        }

        public override void ShowForClient(int clientId)
        {
            IEnumerable<PackageObject> packages = Service.GetAllAvailableForClient(clientId);

            Packages = packages;

            View.ShowPackages(packages);
        }
    }
}
