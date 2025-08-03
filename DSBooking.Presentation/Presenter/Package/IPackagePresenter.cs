using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Package;
using DSBooking.Domain.Entity.Package;

namespace DSBooking.Presentation.Presenter.Package
{
    public interface IPackagePresenter : IPresenter
    {
        void ShowPackages();

        IEnumerable<PackageDTO> Packages { get; }
    }
}
