using DSBooking.Domain.Entity.Package;

namespace DSBooking.Infrastructure.Repository.Package
{
    public interface IPackageRepository
    {
        PackageEntity? Get(int id);

        IEnumerable<PackageEntity> GetAll();
        IEnumerable<PackageEntity> GetAllAvailableForClient(int clientId);
    }
}
