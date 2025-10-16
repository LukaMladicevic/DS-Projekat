using DSBooking.Application.Service.Package;
using DSBooking.Application;
using DSBooking.Presentation.View.PackageAdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Object.Package;
using DSBooking.Domain.Error.Package;

namespace DSBooking.Presentation.Presenter.PackageAdd
{
    public class SimplePackageAddPresenter : PackageAddPresenter
    {
        public SimplePackageAddPresenter(IPackageAddView view, IPackageService service)
            : base(view, service)
        { }

        private void MarkAll(AddResult addResult)
        {
            View.MarkName(PackageAddViewMarkOption.Correct);
            View.MarkPrice(PackageAddViewMarkOption.Correct);
            View.MarkPackageType(PackageAddViewMarkOption.Correct);

            View.MarkDestination(PackageAddViewMarkOption.Correct);
            View.MarkTransportType(PackageAddViewMarkOption.Correct);
            View.MarkAccommodationType(PackageAddViewMarkOption.Correct);

            View.MarkGuide(PackageAddViewMarkOption.Correct);
            View.MarkLengthInDays(PackageAddViewMarkOption.Correct);

            View.MarkShip(PackageAddViewMarkOption.Correct);
            View.MarkRoute(PackageAddViewMarkOption.Correct);
            View.MarkDepartureDate(PackageAddViewMarkOption.Correct);
            View.MarkCabinType(PackageAddViewMarkOption.Correct);

            View.MarkAdditionalActivities(PackageAddViewMarkOption.Correct);

            foreach (var err in addResult.AddObjectErrors)
            {
                if (err is InvalidPackageNameError) View.MarkName(PackageAddViewMarkOption.Incorrect);
                else if (err is InvalidPriceError) View.MarkPrice(PackageAddViewMarkOption.Incorrect);
                else if (err is InvalidPackageTypeError) View.MarkPackageType(PackageAddViewMarkOption.Incorrect);

                else if (err is InvalidDestinationError) View.MarkDestination(PackageAddViewMarkOption.Incorrect);
                else if (err is InvalidTransportTypeError) View.MarkTransportType(PackageAddViewMarkOption.Incorrect);
                else if (err is InvalidAccommodationTypeError) View.MarkAccommodationType(PackageAddViewMarkOption.Incorrect);

                else if (err is InvalidGuideError) View.MarkGuide(PackageAddViewMarkOption.Incorrect);
                else if (err is InvalidLengthError) View.MarkLengthInDays(PackageAddViewMarkOption.Incorrect);

                else if (err is InvalidShipError) View.MarkShip(PackageAddViewMarkOption.Incorrect);
                else if (err is InvalidRouteError) View.MarkRoute(PackageAddViewMarkOption.Incorrect);
                else if (err is InvalidDepartureDateError) View.MarkDepartureDate(PackageAddViewMarkOption.Incorrect);
                else if (err is InvalidCabinTypeError) View.MarkCabinType(PackageAddViewMarkOption.Incorrect);

                else if (err is InvalidAdditionalActivitiesError) View.MarkAdditionalActivities(PackageAddViewMarkOption.Incorrect);
            }
        }

        public override bool DoOnPackageAddSubmitted()
        {
            PackageObject packageObject;

            string packageType = (View.PackageTypeName ?? string.Empty).Trim();

            try
            {
                if (string.Equals(packageType, "Cruise", StringComparison.OrdinalIgnoreCase))
                {
                    var builder = new CruisePackageObject.Builder()
                        .WithName(View.Name)
                        .WithPrice(View.Price)
                        .WithPackageTypeName(View.PackageTypeName ?? string.Empty)
                        .WithShipName(View.ShipName)
                        .WithRouteName(View.RouteName)
                        .WithDepartureDate(View.DepartureDate)
                        .WithCabinTypeName(View.CabinTypeName);

                    packageObject = builder.Build();
                }
                else if (string.Equals(packageType, "Seaside", StringComparison.OrdinalIgnoreCase))
                {
                    var builder = new SeasidePackageObject.Builder()
                        .WithName(View.Name)
                        .WithPrice(View.Price)
                        .WithPackageTypeName(View.PackageTypeName ?? string.Empty)
                        .WithDestinationName(View.DestinationName)
                        .WithTravelTypeName(View.TransportTypeName)
                        .WithAccommodationTypeName(View.AccommodationTypeName);

                    packageObject = builder.Build();
                }
                else if (string.Equals(packageType, "Mountain", StringComparison.OrdinalIgnoreCase))
                {
                    var builder = new MountainPackageObject.Builder()
                        .WithName(View.Name)
                        .WithPrice(View.Price)
                        .WithPackageTypeName(View.PackageTypeName ?? string.Empty)
                        .WithDestinationName(View.DestinationName)
                        .WithTravelTypeName(View.TransportTypeName)
                        .WithAccommodationTypeName(View.AccommodationTypeName)
                        .WithAdditionalActivities(View.AdditionalActivities);

                    packageObject = builder.Build();
                }
                else if (string.Equals(packageType, "Travel", StringComparison.OrdinalIgnoreCase))
                {
                    var builder = new TravelPackageObject.Builder()
                        .WithName(View.Name)
                        .WithPrice(View.Price)
                        .WithPackageTypeName(View.PackageTypeName ?? string.Empty)
                        .WithDestinationName(View.DestinationName)
                        .WithTravelTypeName(View.TransportTypeName)
                        .WithGuideName(View.GuideName)
                        .WithDuration(View.LengthInDays);

                    packageObject = builder.Build();
                }
                else
                {
                    View.MarkPackageType(PackageAddViewMarkOption.Incorrect);
                    return false;
                }
            }
            catch (ArgumentException)
            {
                View.MarkPackageType(PackageAddViewMarkOption.Incorrect);
                return false;
            }
            catch (Exception)
            {
                View.MarkPackageType(PackageAddViewMarkOption.Incorrect);
                return false;
            }

            AddResult addResult;
            try
            {
                addResult = Service.AddPackage(packageObject);
            }
            catch (Exception)
            {
                View.MarkName(PackageAddViewMarkOption.Incorrect);
                View.MarkPrice(PackageAddViewMarkOption.Incorrect);
                View.MarkPackageType(PackageAddViewMarkOption.Incorrect);
                return false;
            }

            MarkAll(addResult);

            return addResult.IsSuccess();
        }
    }
}
