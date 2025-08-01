using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Package;
using DSBooking.Domain.Service.Interface;
using DSBooking.Presentation.Presenter.Interface;
using DSBooking.Presentation.View.Interface;

namespace DSBooking.Presentation.Presenter.Implementation
{
    public class PackagePresenter : IPackagePresenter
    {
        IPackageView _view;
        IPackageService _service;

        public PackagePresenter(IPackageView view, IPackageService packageService)
        {
            _view = view;
            _service = packageService;
        }

        public void ShowAvailablePackages(object? sender, EventArgs e)
        {
            IEnumerable<Package> availablePackages = _service.GetAvailablePackages();

            _view.ShowPackages(availablePackages);
        }
    }
}
