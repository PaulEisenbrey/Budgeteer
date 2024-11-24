using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.Billing.Dbo;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Billing.Dbo;
public class BillingDboCrud : QaLibCrud, IQaLibCrud, IBillingDboCrud
{
    public BillingDboCrud(ILogManager logMgr) : base(logMgr)
    {
        
    }

    public async Task<ReturnValue<BillingDboAccount>> RetrieveAccountTreeByIdAsync(int id, BillingDboContext? dboContext = null)
    {
        try
        {
            var account = await this.EnsureContext(dboContext).Set<BillingDboAccount>()
                .Include(acct => acct.AccountType)
                .Include(acct => acct.InvoiceOwner)
                .Include(acct => acct.NonReferencedCreditMethodType)
                .Include(acct => acct.BankAccount)
                .Include(acct => acct.AccountPolicyholders)
                .Include(acct => acct.InverseInvoiceOwner)
                .Include(acct => acct.PaymentMethodSnapshots)
                .Include(acct => acct.PaymentReschedulingRequests)
                .FirstOrDefaultAsync(acct => acct.Id == id).ConfigureAwait(false);

            var returnVal = null == account ? ReturnValue<BillingDboAccount>.FromError("Billing Account is NULL") : ReturnValue<BillingDboAccount>.From(account);

            return this.GenerateReturnValue(returnVal,  $"Unable to find Billing dbo Account for id {id}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<BillingDboAccount>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<BillingDboAccount>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDboAccount>> RetrieveAccountByZuoraIdAsync(string zuoraId, BillingDboContext? dboContext = null)
    {
        try
        {
            Expression<Func<BillingDboAccount, bool>> predicate = acct => acct.ExternalId == zuoraId;
            var account = await this.RetrieveByQueryAsync(predicate, dboContext).ConfigureAwait(false);

            return !account.IsValid
                    ? ReturnValue<BillingDboAccount>.FromError(account.ErrorText)
                    : null == account.Result
                        ? ReturnValue<BillingDboAccount>.FromError($"No Results found for Zuora Id{zuoraId}")
                        : ReturnValue<BillingDboAccount>.From(account.Result!);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<BillingDboAccount>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<BillingDboAccount>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDboAccount>> RetrieveAccountTreeByZuoraIdAsync(string zuoraId, BillingDboContext? dboContext = null)
    {
        try
        {
            var account = await this.EnsureContext(dboContext).Set<BillingDboAccount>()
                .Include(acct => acct.AccountType)
                .Include(acct => acct.InvoiceOwner)
                .Include(acct => acct.NonReferencedCreditMethodType)
                .Include(acct => acct.BankAccount)
                .Include(acct => acct.AccountPolicyholders)
                .Include(acct => acct.InverseInvoiceOwner)
                .Include(acct => acct.PaymentMethodSnapshots)
                .Include(acct => acct.PaymentReschedulingRequests)
                .FirstOrDefaultAsync(acct => acct.ExternalId == zuoraId).ConfigureAwait(false);
            return null == account
                ? ReturnValue<BillingDboAccount>.FromError($"Unable to find Billing dbo Account for Zuoraid {zuoraId}")
                : ReturnValue<BillingDboAccount>.From(account);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<BillingDboAccount>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDboAccount>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDboAccountPolicyholder>> RetrieveAccountPolicyHolderByOwnerIdAsync(int ownerId, BillingDboContext? dboContext = null)
    {
        try
        {
            Expression<Func<BillingDboAccountPolicyholder, bool>> predicate = x => x.AccountId == ownerId;
            var accounts = await this.RetrieveByQueryAsync(predicate, dboContext).ConfigureAwait(false);

            return !accounts.IsValid
                ? ReturnValue<BillingDboAccountPolicyholder>.FromError(accounts.ErrorText)
                : null == accounts.Result
                    ? ReturnValue<BillingDboAccountPolicyholder>.FromError($"No Results found for Entity Note Id {ownerId}")
                    : ReturnValue<BillingDboAccountPolicyholder>.From(accounts.Result!);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<BillingDboAccountPolicyholder>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDboAccountPolicyholder>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDboAccountPolicyholder>> RetrieveAccountPolicyHolderTreeByOwnerIdAsync(int ownerId, BillingDboContext? dboContext = null)
    {
        try
        {
            var account = await this.EnsureContext(dboContext).Set<BillingDboAccountPolicyholder>()
                .Include(aph => aph.Account)
                .Include(aph => aph.AccountType)
                .FirstOrDefaultAsync(acct => acct.AccountId == ownerId)
                .ConfigureAwait(false);
            
            return null == account
                ? ReturnValue<BillingDboAccountPolicyholder>.FromError($"Unable to find Billing dbo Account for OwnerId {ownerId}")
                : ReturnValue<BillingDboAccountPolicyholder>.From(account);
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDboAccountPolicyholder>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDboAccountPolicyholder>> RetrieveAccountPolicyHolderByOwnerUniqueIdAsync(Guid unqueId, BillingDboContext? dboContext = null)
    {
        try
        {
            Expression<Func<BillingDboAccountPolicyholder, bool>> predicate = acct => acct.PolicyholderUniqueId == unqueId;
            var accountPhs = await this.RetrieveByQueryAsync(predicate, dboContext).ConfigureAwait(false);

            return !accountPhs.IsValid
                    ? ReturnValue<BillingDboAccountPolicyholder>.FromError(accountPhs.ErrorText)
                    : null == accountPhs.Result
                        ? ReturnValue<BillingDboAccountPolicyholder>.FromError($"No Results found for Owner Unique Id {unqueId}")
                        : ReturnValue<BillingDboAccountPolicyholder>.From(accountPhs.Result!);
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDboAccountPolicyholder>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDboAccountPolicyholder>> RetrieveAccountPolicyHolderTreeByOwnerUniqueIdAsync(Guid ownerUniqueId, BillingDboContext? dboContext = null)
    {
        try
        {
            var account = await this.EnsureContext(dboContext).Set<BillingDboAccountPolicyholder>()
                .Include(aph => aph.Account)
                .Include(aph => aph.AccountType)
                .FirstOrDefaultAsync(acct => acct.PolicyholderUniqueId == ownerUniqueId).ConfigureAwait(false);
            return null == account
                ? ReturnValue<BillingDboAccountPolicyholder>.FromError($"Unable to find Billing dbo Account for Owner UniqueId {ownerUniqueId}")
                : ReturnValue<BillingDboAccountPolicyholder>.From(account);
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDboAccountPolicyholder>.FromError(ex);
        }
    }
}
