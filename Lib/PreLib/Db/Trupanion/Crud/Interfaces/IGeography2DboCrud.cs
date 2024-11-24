using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.Geography2.Dbo;
using Utilities.Constants.Enum;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface IGeography2DboCrud : IQaLibCrud
{
    Task<ReturnValue<List<Geography2DboCity>>> RetrieveCitiesByPostalCode(Geography2DboPostalCode postalCode, Geography2DboContext? context = null);
    Task<ReturnValue<Geography2DboPostalCode>> RetrievePostalCodeByZipAsync(string? zipCode, Geography2DboContext? context = null);
    Task<ReturnValue<List<Geography2DboPostalCode>>> RetrievePostalCodesByStateAsync(TrupStates state, Geography2DboContext? context = null);
    Task<ReturnValue<Geography2DboPostalCode>> RetrievePostalCodeTreeByZipAsync(string zipCode, Geography2DboContext? context = null);
    Task<ReturnValue<List<Geography2DboPostalCode>>> RetrievePostalCodeTreesByStateAsync(TrupStates state, Geography2DboContext? context = null);
    Task<ReturnValue<Geography2DboState>> RetrieveStateByStateAbbrAsync(string? stateAbbr, Geography2DboContext? context = null);
    Task<ReturnValue<Geography2DboState>> RetrieveStateByStateNameAsync(string? stateName, Geography2DboContext? context = null);
    Task<ReturnValue<Geography2DboState>> RetrieveStateTreeByStateAbbrAsync(string? stateAbbr, Geography2DboContext? context = null);
    Task<ReturnValue<Geography2DboState>> RetrieveStateTreeByStateNameAsync(string? stateName, Geography2DboContext? context = null);
}