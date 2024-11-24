using Database.Trupanion.Context;
using Database.Trupanion.Projections.Geography.Dbo;
using Utilities.Constants.Enum;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces
{
    public interface IGeographyDboProjectionCrud
    {
        Task<ReturnValue<List<GeographyStateProjection>>> RetrieveAllStateProjectionsAsync(GeographyDboContext? context = null);
        Task<ReturnValue<LatitudeAndLongitudeProjection>> RetrieveLatLonProjectionByPostalCodeAsync(string postalCode, GeographyDboContext? context = null);
        Task<ReturnValue<GeographyStateProjection>> RetrieveStateProjectionByStateAsync(TrupStates state, GeographyDboContext? context = null);
    }
}