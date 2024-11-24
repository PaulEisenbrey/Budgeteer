using System.Linq.Expressions;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using Trupanion.Test.QaLib.Database.GeographyDbo;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Projections.Geography.Dbo;
using Utilities.Constants.Enum;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Geography.Dbo;

public class GeographyDboProjectionCrud : QaLibCrud, IQaLibCrud, IGeographyDboProjectionCrud
{
    public GeographyDboProjectionCrud(ILogManager logMgr) : base(logMgr)
    {
    }

    public async Task<ReturnValue<List<GeographyStateProjection>>> RetrieveAllStateProjectionsAsync(GeographyDboContext? context = null)
    {
        try
        {
            var geoStates = await this.EnsureContext(context).States.Select(state => new GeographyStateProjection
            {
                CountryId = state.CountryId,
                Id = state.Id,
                Name = state.Name,
                StateCode = state.StateCode
            })
            .ToListAsync()
            .ConfigureAwait(false);

            return null == geoStates
                ? ReturnValue<List<GeographyStateProjection>>.FromError("Unable to retrieve States from Geography database")
                : ReturnValue<List<GeographyStateProjection>>.From(geoStates);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<GeographyStateProjection>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<GeographyStateProjection>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<GeographyStateProjection>> RetrieveStateProjectionByStateAsync(TrupStates state, GeographyDboContext? context = null)
    {
        try
        {
            var stateId = (int)state;

            var geoState = await this.EnsureContext(context).States.Select(geoState => new GeographyStateProjection
            {
                CountryId = geoState.CountryId,
                Id = geoState.Id,
                Name = geoState.Name,
                StateCode = geoState.StateCode
            })
            .Where(n => n.Id == stateId)
            .FirstOrDefaultAsync()
            .ConfigureAwait(false);

            return null == geoState
                ? ReturnValue<GeographyStateProjection>.FromError($"Unable to retrieve {state} from Geography database")
                : ReturnValue<GeographyStateProjection>.From(geoState);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<GeographyStateProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<GeographyStateProjection>.FromError(ex);
        }
    }

    public async Task<ReturnValue<LatitudeAndLongitudeProjection>> RetrieveLatLonProjectionByPostalCodeAsync(string postalCode, GeographyDboContext? context = null)
    {
        try
        {
            var geoState = await this.EnsureContext(context).PostalCodes.Select(postCode => new LatitudeAndLongitudeProjection
            {
                PostalCode = postCode.PostalCode,
                Latitude = postCode.Lat,
                Longitude = postCode.Lon
            })
            .Where(n => n.PostalCode == postalCode)
            .FirstOrDefaultAsync()
            .ConfigureAwait(false);

            return null == geoState
                ? ReturnValue<LatitudeAndLongitudeProjection>.FromError($"Unable to retrieve {postalCode} from Geography database")
                : ReturnValue<LatitudeAndLongitudeProjection>.From(geoState);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<LatitudeAndLongitudeProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<LatitudeAndLongitudeProjection>.FromError(ex);
        }
    }
}