using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.TestData.AnnualNotification;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.TestData.AnnualNotification;

public class TestDataAnnualNotificationCrud : QaLibCrud, IQaLibCrud, ITestDataAnnualNotificationCrud
{
    public TestDataAnnualNotificationCrud(ILogManager logMgr) : base(logMgr)
    {
        
    }
    public async Task<ReturnValue<List<TestDataAnnualNotificationAddress>>> RetrieveAllAddressesAsync(TestDataAnnualNotificationContext? context = null)
    {
        try
        {
            var addresses = await this.EnsureContext(context).Addresses.ToListAsync().ConfigureAwait(false);

            return 0 == addresses.Count()
                ? ReturnValue<List<TestDataAnnualNotificationAddress>>.FromError("No Addresses found")
                : ReturnValue<List<TestDataAnnualNotificationAddress>>.From(addresses);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<TestDataAnnualNotificationAddress>>.FromError(ex);

        }
    }

    public async Task<ReturnValue<List<TestDataAnnualNotificationAddress>>> RetrieveAllAddressesByStateAbbrAsync(string? stateAbbr, TestDataAnnualNotificationContext? context = null)
    {
        EvaluateArgument.Execute(stateAbbr, fn => !string.IsNullOrEmpty(stateAbbr), "State Abbreviation must be a valid string");

        try
        {
            var loCaseStateAbbr = stateAbbr?.ToLower() ?? "";

            var addresses = await this.EnsureContext(context).Addresses.Where(addr => addr.StateAbbr.ToLower().Equals(loCaseStateAbbr)).ToListAsync().ConfigureAwait(false);

            return 0 == addresses.Count()
                ? ReturnValue<List<TestDataAnnualNotificationAddress>>.FromError("No Addresses found")
                : ReturnValue<List<TestDataAnnualNotificationAddress>>.From(addresses);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<TestDataAnnualNotificationAddress>>.FromError(ex);

        }
    }

    public async Task<ReturnValue<List<TestDataAnnualNotificationConfiguration>>>RetrieveConfigurationItemsAsync(TestDataAnnualNotificationContext? context = null)
    {
        try
        {
            var config = await this.EnsureContext(context).Configurations.ToListAsync().ConfigureAwait(false);

            return 0 == config.Count()
                ? ReturnValue<List<TestDataAnnualNotificationConfiguration>>.FromError("No Configurations found")
                : ReturnValue<List<TestDataAnnualNotificationConfiguration>>.From(config);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<TestDataAnnualNotificationConfiguration>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataAnnualNotificationPet>>> RetrievePetsAsync(TestDataAnnualNotificationContext? context = null)
    {
        try
        {
            var pets = await this.EnsureContext(context).Pets.ToListAsync().ConfigureAwait(false);

            return 0 == pets.Count()
                ? ReturnValue<List<TestDataAnnualNotificationPet>>.FromError("No Pets found")
                : ReturnValue<List<TestDataAnnualNotificationPet>>.From(pets);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<TestDataAnnualNotificationPet>>.FromError(ex);
        }
    }
}
