using DSBooking.Domain.Object.Package;

namespace DSBooking.Infrastructure.Repository.Package
{
    public interface IPackageRepository
    {
        PackageObject? Get(int id);
        IEnumerable<PackageObject> GetAllAvailablePackages(int clientId);
    }
}
