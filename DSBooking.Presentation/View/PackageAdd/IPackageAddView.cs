using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Presentation.View.PackageAdd
{
    public enum PackageAddViewMarkOption { Correct, Incorrect }

    public interface IPackageAddView
    {
        // Basic fields
        string Name { get; }
        double Price { get; }
        string PackageTypeName { get; } // e.g. "Seaside", "Travel", "Cruise", "Mountain"

        // Seaside / Mountain / Travel (destination/transport/accommodation)
        string DestinationName { get; }
        string TransportTypeName { get; }
        string AccommodationTypeName { get; }

        // Travel
        string GuideName { get; }
        int LengthInDays { get; }

        // Cruise
        string ShipName { get; }
        string RouteName { get; }
        DateTime DepartureDate { get; }
        string CabinTypeName { get; }

        // Mountain extra
        string AdditionalActivities { get; }

        // Marking methods (UI feedback)
        void MarkName(PackageAddViewMarkOption option);
        void MarkPrice(PackageAddViewMarkOption option);
        void MarkPackageType(PackageAddViewMarkOption option);

        void MarkDestination(PackageAddViewMarkOption option);
        void MarkTransportType(PackageAddViewMarkOption option);
        void MarkAccommodationType(PackageAddViewMarkOption option);

        void MarkGuide(PackageAddViewMarkOption option);
        void MarkLengthInDays(PackageAddViewMarkOption option);

        void MarkShip(PackageAddViewMarkOption option);
        void MarkRoute(PackageAddViewMarkOption option);
        void MarkDepartureDate(PackageAddViewMarkOption option);
        void MarkCabinType(PackageAddViewMarkOption option);

        void MarkAdditionalActivities(PackageAddViewMarkOption option);

        // UI events
        event EventHandler? PackageAddSubmitted;
        event EventHandler? PackageAddCancelled;
    }
}
