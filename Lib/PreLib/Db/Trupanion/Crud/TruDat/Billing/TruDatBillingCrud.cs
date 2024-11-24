using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.TruDat.Claim;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.TruDat.Billing;

public class TruDatBillingCrud : QaLibCrud, IQaLibCrud, ITruDatBillingCrud
{
    public TruDatBillingCrud(ILogManager logMgr) : base(logMgr)
    {
        
    }

    public async Task<ReturnValue<TruDatBillingAmazonBillingAgreement>> RetrieveAmazonBillingAgreementByOwnerIdAsync(int ownerId, TruDatBillingContext? context = null)
    {
        EvaluateArgument.Execute(ownerId, fn => 0 < ownerId, "OwnerId must be a positive non-zero integer");

        try
        {
            Expression<Func<TruDatBillingAmazonBillingAgreement, bool>> predicate = ab => ab.OwnerId == ownerId;
            var billingAgreement = await this.RetrieveByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(billingAgreement, $"Unable to find billing agreement for owner {ownerId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatBillingAmazonBillingAgreement>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatBillingAmazonBillingAgreement>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatBillingAssociateBankAccount>> RetrieveAmazonBillingAssociateBankAccountByAssociateIdAsync(int associateId, TruDatBillingContext? context = null)
    {
        EvaluateArgument.Execute(associateId, fn => 0 < associateId, "associateId must be a positive non-zero integer");

        try
        {
            Expression<Func<TruDatBillingAssociateBankAccount, bool>> predicate = ab => ab.AssociateAccountId == associateId;
            var associateBank = await this.RetrieveByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(associateBank,
                $"Unable to find account agreement for Associate {associateId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatBillingAssociateBankAccount>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatBillingAssociateBankAccount>.FromError(ex);
        }
    }
}
