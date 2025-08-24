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
    public class PackagePresenter : IPackagePresenter
    {
        IPackageView _view;
        IPackageService _service;

        IEnumerable<PackageObject> _packages;

        public PackagePresenter(IPackageView view, IPackageService service)
        {
            _view = view;
            _service = service;

            _packages = new List<PackageObject>();
        }

        public IEnumerable<PackageObject> Packages => _packages;

        public void ShowAll()
        {
            IEnumerable<PackageObject> packages = _service.GetAll();

            _packages = packages;

            _view.ShowPackages(packages);
        }

        public void ShowForClient(int clientId)
        {
            IEnumerable<PackageObject> packages = _service.GetAllAvailableForClient(clientId);

            _packages = packages;

            _view.ShowPackages(packages);
        }
    }
}
