using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Package;

namespace DSBooking.Presentation.Presenter.Package
{
    public interface IPackagePresenter
    {
        void ShowForClient(int clientId);
        void ShowAll();

        IEnumerable<PackageEntity> Packages { get; }
    }
}
