using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Application.DTO.Package;
using DSBooking.Domain.Entity.Package;

namespace DSBooking.Presentation.View.Package
{
    public interface IPackageView : IView
    {
        event EventHandler<PackageDTO>? OnSelectedPackage;

        void ShowPackages(IEnumerable<PackageDTO> packages);
    }
}
