using Microsoft.EntityFrameworkCore;

using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.TestData.PurchaseProcessDbo;
using Utilities.Logging;
using Utilities.ReturnType;
using System;
using Microsoft.Data.SqlClient;
using Utilities.ArgumentEvaluation;
using Utilities.Constants.Enum;
using Database.Trupanion.Entity.PurchaseProcess.Dbo;

namespace Database.Trupanion.Crud.PurchaseProcess.Dbo;

public class PurchaseProcessDboCrud : QaLibCrud, IQaLibCrud, IPurchaseProcessDboCrud
{
    public PurchaseProcessDboCrud(ILogManager logMgr) : base(logMgr)
    {
    }

    public ReturnValue<string> RetrieveNextPolicyNumber(PriceEngine priceEngine, PurchaseProcessDboContext? context = null)
    {
        try
        {
            EvaluateArgument.Execute(priceEngine, fn => PriceEngine.Uninitialized != priceEngine && PriceEngine.OutOfRange != priceEngine, "Invalid Price Engine");

            var policyNumber = this.EnsureContext(context)
                .Database
                .SqlQuery<string>($"delete top (1) AvailablePolicyNumber output deleted.PolicyNumber where EngineId = {(int)priceEngine}")
                .ToList<string>();

            return policyNumber != null && policyNumber.Any()
                ? ReturnValue<string>.From(policyNumber.First())
                : ReturnValue<string>.FromError("Unable to retrieve next Policy Number");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<string>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<string>.FromError(ex);
        }
    }

    public async Task<ReturnValue<PPDboEnrollmentDatum>> SaveEnrollmentDataAsync(PPDboEnrollmentDatum newEnrollment, PurchaseProcessDboContext? context = null)
    {
        try
        {
            var ctx = this.EnsureContext(context);

            var retVal = await ctx.EnrollmentData.AddAsync(newEnrollment);
            await ctx.SaveChangesAsync().ConfigureAwait(false);

            return ReturnValue<PPDboEnrollmentDatum>.From(retVal.Entity);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<PPDboEnrollmentDatum>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<PPDboEnrollmentDatum>.FromError(ex);
        }
    }
}