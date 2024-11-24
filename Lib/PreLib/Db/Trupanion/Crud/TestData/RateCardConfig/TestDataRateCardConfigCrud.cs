using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.TestData.RateCardConfig;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.TestData.RateCardConfig;

public class TestDataRateCardConfigCrud : QaLibCrud, IQaLibCrud, ITestDataRateCardConfigCrud
{
    public TestDataRateCardConfigCrud(ILogManager logMgr) : base(logMgr)
    {
        
    }

    public async Task<ReturnValue<List<TestDataRateCardConfigRateCardColumn>>> RetrieveAllRateCardColumnsAsync(TestDataRateCardConfigContext? context = null)
    {
        try
        {
            var configColumns = await this.EnsureContext(context).RateCardColumns.ToListAsync().ConfigureAwait(false);

            return 0 >= configColumns.Count()
                ? ReturnValue<List<TestDataRateCardConfigRateCardColumn>>.FromError($"No Columns Found")
                : ReturnValue<List<TestDataRateCardConfigRateCardColumn>>.From(configColumns);
        }
        catch(SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataRateCardConfigRateCardColumn>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataRateCardConfigRateCardColumn>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataRateCardConfigRateCardRowset>>> RetrieveAllRateCardRowSetsAsync(TestDataRateCardConfigContext? context = null)
    {
        try
        {
            var configRowSets = await this.EnsureContext(context).RateCardRowsets.ToListAsync().ConfigureAwait(false);

            return 0 >= configRowSets.Count()
                ? ReturnValue<List<TestDataRateCardConfigRateCardRowset>>.FromError($"No Rowsets Found")
                : ReturnValue<List<TestDataRateCardConfigRateCardRowset>>.From(configRowSets);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataRateCardConfigRateCardRowset>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataRateCardConfigRateCardRowset>>.FromError(ex);
        }
    }
    public async Task<ReturnValue<List<TestDataRateCardConfigRateCardSection>>> RetrieveAllRateCardSectionsAsync(TestDataRateCardConfigContext? context = null)
    {
        try
        {
            var configSections = await this.EnsureContext(context).RateCardSections.ToListAsync().ConfigureAwait(false);

            return 0 >= configSections.Count()
                ? ReturnValue<List<TestDataRateCardConfigRateCardSection>>.FromError($"No Sections Found")
                : ReturnValue<List<TestDataRateCardConfigRateCardSection>>.From(configSections);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataRateCardConfigRateCardSection>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataRateCardConfigRateCardSection>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataRateCardConfigRateCardTab>>> RetrieveAllRateCardTabsAsync(TestDataRateCardConfigContext? context = null)
    {
        try
        {
            var configTabs = await this.EnsureContext(context).RateCardTabs.ToListAsync().ConfigureAwait(false);

            return 0 >= configTabs.Count()
                ? ReturnValue<List<TestDataRateCardConfigRateCardTab>>.FromError($"No Tabs Found")
                : ReturnValue<List<TestDataRateCardConfigRateCardTab>>.From(configTabs);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataRateCardConfigRateCardTab>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataRateCardConfigRateCardTab>>.FromError(ex);
        }
    }
}
