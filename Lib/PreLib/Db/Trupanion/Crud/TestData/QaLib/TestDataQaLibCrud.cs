using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.TestData.QaLib;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.TestData.QaLib;

public class TestDataQaLibCrud : QaLibCrud, IQaLibCrud, ITestDataQaLibCrud
{
    public TestDataQaLibCrud(ILogManager logMgr) : base(logMgr)
    {

    }


    public async Task<ReturnValue<TestDataQaLibKeyValueConfiguration>> RetrieveKeyValueRowsAsync(string key, TestDataQaLibContext? context = null)
    {
        EvaluateArgument.Execute(key, fn => !string.IsNullOrEmpty(key), "the key must be a valid string");

        try
        {
            var lowKey = key.ToLower();
            var value = await this.EnsureContext(context).KeyValueConfigurations.FirstOrDefaultAsync(kv => kv.ConfigKey.ToLower().Equals(lowKey)).ConfigureAwait(false);

            return null == value
                ? ReturnValue<TestDataQaLibKeyValueConfiguration>.FromError($"Unable to find Configuration for {key}")
                : ReturnValue<TestDataQaLibKeyValueConfiguration>.From(value);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TestDataQaLibKeyValueConfiguration>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TestDataQaLibKeyValueConfiguration>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TestDataQaLibPendingEnrollment>> RetrievePendingEnrollmentAsync(int ownerId, TestDataQaLibContext? context = null)
    {
        EvaluateArgument.Execute(ownerId, fn => 0 < ownerId, "Owner Id must be a valid positive integer");

        try
        {
            var pendingEnrollment = await this.EnsureContext(context).PendingEnrollments.FirstOrDefaultAsync(pe => pe.OwnerId == ownerId).ConfigureAwait(false);

            return null == pendingEnrollment
                ? ReturnValue<TestDataQaLibPendingEnrollment>.FromError($"Unable to find pending enrollment for owner id {ownerId}")
                : ReturnValue<TestDataQaLibPendingEnrollment>.From(pendingEnrollment);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TestDataQaLibPendingEnrollment>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TestDataQaLibPendingEnrollment>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TestDataQaLibTestOwner>> RetrieveTestOwnerAsync(int ownerId, TestDataQaLibContext? context = null)
    {
        EvaluateArgument.Execute(ownerId, fn => 0 < ownerId, "Owner Id must be a valid positive integer");

        try
        {
            var testOwner = await this.EnsureContext(context).TestOwners.FirstOrDefaultAsync(pe => pe.OwnerId == ownerId).ConfigureAwait(false);

            return null == testOwner
                ? ReturnValue<TestDataQaLibTestOwner>.FromError($"Unable to find testOwner for owner id {ownerId}")
                : ReturnValue<TestDataQaLibTestOwner>.From(testOwner);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TestDataQaLibTestOwner>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TestDataQaLibTestOwner>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TestDataQaLibPendingEnrollment>> CreatePendingEnrollmentAsync(TestDataQaLibPendingEnrollment pendingEnrollment, TestDataQaLibContext? context = null)
    {
        try
        {
            var ctx = this.EnsureContext(context);
            var retVal = await ctx.PendingEnrollments.AddAsync(pendingEnrollment).ConfigureAwait(false);
            await ctx.SaveChangesAsync().ConfigureAwait(false);

            return ReturnValue<TestDataQaLibPendingEnrollment>.From(retVal.Entity);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TestDataQaLibPendingEnrollment>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TestDataQaLibPendingEnrollment>.FromError(ex);
        }
    }
}
