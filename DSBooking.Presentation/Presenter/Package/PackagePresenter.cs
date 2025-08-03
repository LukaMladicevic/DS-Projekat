using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Package;
using DSBooking.Application.Service.Package;
using DSBooking.Domain.Entity.Package;
using DSBooking.Presentation.View.Package;

namespace DSBooking.Presentation.Presenter.Package
{
    public class PackagePresenter : IPackagePresenter
    {
        IPackageView _view;
        IPackageService _service;

        IEnumerable<PackageDTO> _packages;

        public PackagePresenter(IPackageView view, IPackageService service)
        {
            _view = view;
            _service = service;

            _packages = new List<PackageDTO>();
        }

        public IEnumerable<PackageDTO> Packages => _packages;

        public void Initialize()
        {
        }

        public void ShowPackages()
        {
            IEnumerable<PackageDTO> packages = _service.GetAllPackages();

            _packages = packages;

            _view.ShowPackages(packages);
        }
    }
}
