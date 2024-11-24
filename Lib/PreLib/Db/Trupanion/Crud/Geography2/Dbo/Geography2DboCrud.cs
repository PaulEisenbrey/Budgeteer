using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.Geography2.Dbo;
using Utilities.ArgumentEvaluation;
using Utilities.Constants.Enum;
using Utilities.Extension;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Geography2.Dbo;

public class Geography2DboCrud : QaLibCrud, IQaLibCrud, IContextGenerator, IGeography2DboCrud
{
    public Geography2DboCrud(ILogManager logMgr) : base(logMgr)
    {
        
    }

    public async Task<ReturnValue<Geography2DboPostalCode>> RetrievePostalCodeByZipAsync(string? zipCode, Geography2DboContext? context = null)
    {
        EvaluateArgument.Execute(zipCode, fn => !string.IsNullOrEmpty(zipCode), "zipCode cannot be empty");

        try
        {
            var lowZip = zipCode?.ToLower();
            var zipValue = await this.EnsureContext(context).PostalCodes.FirstOrDefaultAsync(zipCode => zipCode.Code.ToLower() == lowZip).ConfigureAwait(false);
            return null == zipValue
                ? ReturnValue<Geography2DboPostalCode>.FromError($"Unable to retrieve Postal Code for {zipCode}")
                : ReturnValue<Geography2DboPostalCode>.From(zipValue);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<Geography2DboPostalCode>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<Geography2DboPostalCode>.FromError(ex);
        }
    }

    public async Task<ReturnValue<Geography2DboPostalCode>> RetrievePostalCodeTreeByZipAsync(string zipCode, Geography2DboContext? context = null)
    {
        EvaluateArgument.Execute(zipCode, fn => !string.IsNullOrEmpty(zipCode), "zipCode cannot be empty");

        try
        {
            var lowZip = zipCode.ToLower();
            var zipValue = await this.EnsureContext(context).PostalCodes
                .Include(zip => zip.Country)
                .Include(zip => zip.PostalCodeCities)
                .Include(zip => zip.PostalCodeCounties)
                .Include(zip => zip.PostalCodeStates)
                .FirstOrDefaultAsync(zipCode => zipCode.Code.ToLower() == lowZip).ConfigureAwait(false);
            return null == zipValue
                ? ReturnValue<Geography2DboPostalCode>.FromError($"Unable to retrieve Postal Code for {zipCode}")
                : ReturnValue<Geography2DboPostalCode>.From(zipValue);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<Geography2DboPostalCode>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<Geography2DboPostalCode>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<Geography2DboPostalCode>>> RetrievePostalCodesByStateAsync(TrupStates state, Geography2DboContext? context = null)
    {
        EvaluateArgument.Execute(state, fn => state != TrupStates.Uninitialized && state != TrupStates.OutOfRange, $"State {state} is not valid");

        try
        {
            var ctx = this.EnsureContext(context);
            var postalCodeIds = await ctx.PostalCodeStates.Where(pcs => pcs.StateId == (int)state).ToListAsync().ConfigureAwait(false);
            var idList = postalCodeIds.Select(p => p.PostalCodeId).ToList();

            var zipRecs = await ctx.PostalCodes.Where(pc => idList.Contains(pc.Id)).ToListAsync().ConfigureAwait(false);

            return 0 == zipRecs.Count()
                ? ReturnValue<List<Geography2DboPostalCode>>.FromError($"Unable to find postal codes for state {state.Description()}")
                : ReturnValue<List<Geography2DboPostalCode>>.From(zipRecs);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<Geography2DboPostalCode>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<List<Geography2DboPostalCode>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<Geography2DboPostalCode>>> RetrievePostalCodeTreesByStateAsync(TrupStates state, Geography2DboContext? context = null)
    {
        EvaluateArgument.Execute(state, fn => state != TrupStates.Uninitialized && state != TrupStates.OutOfRange, $"State {state} is not valid");

        try
        {
            var ctx = this.EnsureContext(context);
            var postalCodeIds = await ctx.PostalCodeStates.Where(pcs => pcs.StateId == (int)state).ToListAsync().ConfigureAwait(false);
            var idList = postalCodeIds.Select(p => p.PostalCodeId).ToList();

            var zipRecs = await ctx.PostalCodes
                .Include(zip => zip.Country)
                .Include(zip => zip.PostalCodeCities)
                .Include(zip => zip.PostalCodeCounties)
                .Include(zip => zip.PostalCodeStates)
                .Where(pc => idList.Contains(pc.Id)).ToListAsync().ConfigureAwait(false);

            return 0 == zipRecs.Count()
                ? ReturnValue<List<Geography2DboPostalCode>>.FromError($"Unable to find postal codes for state {state.Description()}")
                : ReturnValue<List<Geography2DboPostalCode>>.From(zipRecs);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<Geography2DboPostalCode>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<List<Geography2DboPostalCode>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<Geography2DboState>> RetrieveStateByStateAbbrAsync(string? stateAbbr, Geography2DboContext? context = null)
    {
        try
        {
            EvaluateArgument.Execute(stateAbbr, fn => !string.IsNullOrEmpty(stateAbbr), $"State abbreviation cannot be null or empty");
            var upcaseState = stateAbbr?.ToUpper();

            var geoState = await this.EnsureContext(context).States.FirstOrDefaultAsync(st => st.StateCode.ToUpper() == upcaseState).ConfigureAwait(false);

            return null == geoState
                ? ReturnValue<Geography2DboState>.FromError($"Unable to locate state abbreviation {stateAbbr}")
                : ReturnValue<Geography2DboState>.From(geoState);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<Geography2DboState>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<Geography2DboState>.FromError(ex);
        }
    }

    public async Task<ReturnValue<Geography2DboState>> RetrieveStateTreeByStateAbbrAsync(string? stateAbbr, Geography2DboContext? context = null)
    {
        try
        {
            EvaluateArgument.Execute(stateAbbr, fn => !string.IsNullOrEmpty(stateAbbr), $"State abbreviation cannot be null or empty");
            var upcaseState = stateAbbr?.ToUpper();

            var geoState = await this.EnsureContext(context).States
                .Include(st => st.Country)
                .Include(st => st.Cities)
                .Include(st => st.Counties)
                .Include(st => st.PostalCodeStates)
                .FirstOrDefaultAsync(st => st.StateCode.ToUpper() == upcaseState).ConfigureAwait(false);

            return null == geoState
                ? ReturnValue<Geography2DboState>.FromError($"Unable to locate state abbreviation {stateAbbr}")
                : ReturnValue<Geography2DboState>.From(geoState);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<Geography2DboState>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<Geography2DboState>.FromError(ex);
        }
    }

    public async Task<ReturnValue<Geography2DboState>> RetrieveStateByStateNameAsync(string? stateName, Geography2DboContext? context = null)
    {
        try
        {
            EvaluateArgument.Execute(stateName, fn => !string.IsNullOrEmpty(stateName), $"State Name cannot be null or empty");
            var upcaseState = stateName?.ToUpper();

            var geoState = await this.EnsureContext(context).States.FirstOrDefaultAsync(st => st.Name.ToUpper() == upcaseState).ConfigureAwait(false);

            return null == geoState
                ? ReturnValue<Geography2DboState>.FromError($"Unable to locate state name {stateName}")
                : ReturnValue<Geography2DboState>.From(geoState);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<Geography2DboState>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<Geography2DboState>.FromError(ex);
        }
    }

    public async Task<ReturnValue<Geography2DboState>> RetrieveStateTreeByStateNameAsync(string? stateName, Geography2DboContext? context = null)
    {
        try
        {
            EvaluateArgument.Execute(stateName, fn => !string.IsNullOrEmpty(stateName), $"State Name cannot be null or empty");
            var upcaseState = stateName?.ToUpper();

            var geoState = await this.EnsureContext(context).States
                .Include(st => st.Country)
                .Include(st => st.Cities)
                .Include(st => st.Counties)
                .Include(st => st.PostalCodeStates)
                .FirstOrDefaultAsync(st => st.Name.ToUpper() == upcaseState).ConfigureAwait(false);

            return null == geoState
                ? ReturnValue<Geography2DboState>.FromError($"Unable to locate state name {stateName}")
                : ReturnValue<Geography2DboState>.From(geoState);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<Geography2DboState>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<Geography2DboState>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<Geography2DboCity>>> RetrieveCitiesByPostalCode(Geography2DboPostalCode postalCode, Geography2DboContext? context = null)
    {
        try
        {
            var ctx = this.EnsureContext(context);
            var cityList = await ctx.PostalCodeCities.Where(pcc => pcc.PostalCodeId == postalCode.Id).ToListAsync().ConfigureAwait(false);
            EvaluateArgument.Execute(cityList, fn => null != cityList, $"No cities found for postal code {postalCode.Code}");

            var cityIds = cityList.Select(cl => cl.CityId).ToList();

            var cities = await ctx.Cities.Where(c => cityIds.Any(cid => cid == c.Id)).ToListAsync().ConfigureAwait(false);
            EvaluateArgument.Execute(cities, fn => null != cities, "Cities are missing in the database");

            return ReturnValue<List<Geography2DboCity>>.From(cities);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<Geography2DboCity>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (System.Exception ex)
        {
            return ReturnValue<List<Geography2DboCity>>.FromError(ex);
        }
    }
}