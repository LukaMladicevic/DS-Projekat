using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;
using DSBooking.Domain.Service;
using DSBooking.Presentation.Presenter.Interface;
using DSBooking.Presentation.View.Interface;

namespace DSBooking.Presentation.Presenter.Implementation
{
    public class PackagePresenter : IPackagePresenter
    {
        IPackageView _view;
        IPackageService _service;

        IEnumerable<Package> _packages;

        public PackagePresenter(IPackageView view, IPackageService service)
        {
            _view = view;
            _service = service;

            _packages = new List<Package>();
        }

        public IEnumerable<Package> Packages => _packages;

        public void Initialize()
        {
        }

        public void ShowPackages()
        {
            IEnumerable<Package> packages = _service.GetAllPackages();

            _packages = packages;

            _view.ShowPackages(packages);
        }
    }
}
