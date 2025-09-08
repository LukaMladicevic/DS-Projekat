using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Package;
using DSBooking.Infrastructure.Repository.Package;
using System.Diagnostics;

namespace DSBooking.Application.Service.Package
{
    public class PackageService : IPackageService
    {
        IPackageRepository _packageRepository;
        public PackageService(IPackageRepository packageRepository) 
        {
            _packageRepository = packageRepository;
        }
        public IEnumerable<PackageObject> GetAll()
        {

            try
            {
                // Call your repository
                var packages = _packageRepository.GetAll();

                // Check if any packages were returned
                if (!packages.Any())
                {
                    Console.WriteLine("No packages returned from the database.");
                    System.Diagnostics.Debug.WriteLine("No packages returned from the database.");
                }

                // Loop through the results and print key info
                foreach (var p in packages)
                {
                    Console.WriteLine($"PackageId: {p.PackageTypeName}, Name: {p.Name}, Price: {p.Price}");
                    System.Diagnostics.Debug.WriteLine($"PackageId: {p.Id}, Name: {p.Name}, Price: {p.Price}");
                }

                return packages;
            }
            catch (Exception ex)
            {
                // Print the exception message and stack trace
                Console.WriteLine("Error while fetching packages: " + ex.Message);
                Console.WriteLine(ex.StackTrace);

                System.Diagnostics.Debug.WriteLine("Error while fetching packages: " + ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            IEnumerable<PackageObject> objects = new List<PackageObject>();
            return objects;

        }
        public IEnumerable<PackageObject> GetAllAvailableForClient(int clientId)
        {
            return _packageRepository.GetAllAvailableForClient(clientId);
        }
    }
}
