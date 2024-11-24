using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.Billing.DataIntegration;
using Utilities.Extension.DateExtension;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Billing.DataIntegration;

public class BillingDataIntegrationCrud : QaLibCrud, IQaLibCrud, IBillingDataIntegrationCrud
{
    public BillingDataIntegrationCrud(ILogManager logMgr) : base(logMgr)
    {
    }

    // Data Integration Batch Accessors
    public async Task<ReturnValue<BillingDataIntegrationBatch>> RetrieveBatchByIdAsync(int id, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var batch = await this.EnsureContext(context).Batches.FirstOrDefaultAsync(batch => batch.Id.Equals(id)).ConfigureAwait(false);
            return null == batch
                ? ReturnValue<BillingDataIntegrationBatch>.FromError("No batch found for id {id}")
                : ReturnValue<BillingDataIntegrationBatch>.From(batch);
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDataIntegrationBatch>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDataIntegrationBatch>> RetrieveBatchTreeByIdAsync(int id, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var batch = await this.EnsureContext(context).Batches.
                Include(batch => batch.Job)
                .FirstOrDefaultAsync(batch => batch.Id.Equals(id)).ConfigureAwait(false);

            return null == batch
                ? ReturnValue<BillingDataIntegrationBatch>.FromError("No batch found for id {id}")
                : ReturnValue<BillingDataIntegrationBatch>.From(batch);
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDataIntegrationBatch>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<BillingDataIntegrationBatch>>> RetrieveBatchesByJobIdAsync(int jobId, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var batches = await this.EnsureContext(context).Batches.Where(batch => batch.JobId == jobId).ToListAsync().ConfigureAwait(false);
            return 0 == batches.Count()
                ? ReturnValue<List<BillingDataIntegrationBatch>>.FromError($"No batches found for Job Id {jobId}")
                : ReturnValue<List<BillingDataIntegrationBatch>>.From(batches);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<BillingDataIntegrationBatch>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<BillingDataIntegrationBatch>>> RetrieveBatchTreesByJobIdAsync(int jobId, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var batches = await this.EnsureContext(context).Batches.
                Include(batch => batch.Job)
               .Where(batch => batch.JobId == jobId).ToListAsync().ConfigureAwait(false);
            return 0 == batches.Count()
                ? ReturnValue<List<BillingDataIntegrationBatch>>.FromError($"No batches found for Job Id {jobId}")
                : ReturnValue<List<BillingDataIntegrationBatch>>.From(batches);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<BillingDataIntegrationBatch>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDataIntegrationChargeback>> RetrieveChargeBackByIdAsync(int id, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var chargeBack = await this.EnsureContext(context).Chargebacks.FirstOrDefaultAsync(chargeBack => chargeBack.Id.Equals(id)).ConfigureAwait(false);
            return null == chargeBack
                ? ReturnValue<BillingDataIntegrationChargeback>.FromError($"Unable to find ChargeBack record from id {id}")
                : ReturnValue<BillingDataIntegrationChargeback>.From(chargeBack);
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDataIntegrationChargeback>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<BillingDataIntegrationChargeback>>> RetrieveChargeBacksByZuoraIdAsync(string zuoraId, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var chargeBacks = await this.EnsureContext(context).Chargebacks.Where(chargeBack => chargeBack.AccountId == zuoraId).ToListAsync().ConfigureAwait(false);
            return 0 == chargeBacks.Count()
                ? ReturnValue<List<BillingDataIntegrationChargeback>>.FromError($"No charge backs found for Zoura Id {zuoraId}")
                : ReturnValue<List<BillingDataIntegrationChargeback>>.From(chargeBacks);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<BillingDataIntegrationChargeback>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDataIntegrationFailedPayment>> RetrieveFailedPaymentByIdAsync(int id, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var failedPayment = await this.EnsureContext(context).FailedPayments.FirstOrDefaultAsync(failedPayment => failedPayment.Id.Equals(id)).ConfigureAwait(false);
            return null == failedPayment
                ? ReturnValue<BillingDataIntegrationFailedPayment>.FromError($"Unable to locate Failed Payment for id {id}")
                : ReturnValue<BillingDataIntegrationFailedPayment>.From(failedPayment);
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDataIntegrationFailedPayment>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<BillingDataIntegrationFailedPayment>>> RetrieveFailedPaymentsByZuoraIdAsync(string zuoraId, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var failedPmts = await this.EnsureContext(context).FailedPayments.Where(failedPayment => failedPayment.AccountId == zuoraId).ToListAsync().ConfigureAwait(false);
            return 0 == failedPmts.Count()
                ? ReturnValue<List<BillingDataIntegrationFailedPayment>>.FromError($"Unable to located Failed Payments for zouraId {zuoraId}")
                : ReturnValue<List<BillingDataIntegrationFailedPayment>>.From(failedPmts);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<BillingDataIntegrationFailedPayment>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDataIntegrationJob>> RetrieveJobByIdAsync(int id, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var job = await this.EnsureContext(context).Jobs.FirstOrDefaultAsync(job => job.Id.Equals(id)).ConfigureAwait(false);
            return null == job
                ? ReturnValue<BillingDataIntegrationJob>.FromError($"Unable to retrive Job by Id {id}")
                : ReturnValue<BillingDataIntegrationJob>.From(job);
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDataIntegrationJob>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDataIntegrationJob>> RetrieveJobTreeByIdAsync(int id, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var job = await this.EnsureContext(context).Jobs
                .Include(j => j.Batches)
                .FirstOrDefaultAsync(job => job.Id.Equals(id)).ConfigureAwait(false);
            return null == job
                ? ReturnValue<BillingDataIntegrationJob>.FromError($"Unable to retrive Job by Id {id}")
                : ReturnValue<BillingDataIntegrationJob>.From(job);
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDataIntegrationJob>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<BillingDataIntegrationJob>>> RetrieveJobsByZuoraIdAsync(string zuoraId, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var jobs = await this.EnsureContext(context).Jobs.Where(job => job.ExternalId == zuoraId).ToListAsync().ConfigureAwait(false);
            return 0 == jobs.Count()
                    ? ReturnValue<List<BillingDataIntegrationJob>>.FromError($"Unable to located job for zouraId {zuoraId}")
                    : ReturnValue<List<BillingDataIntegrationJob>>.From(jobs);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<BillingDataIntegrationJob>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<BillingDataIntegrationJob>>> RetrieveJobTreesByZuoraIdAsync(string zuoraId, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var jobs = await this.EnsureContext(context).Jobs
                .Include(j => j.Batches)
                .Where(job => job.ExternalId == zuoraId).ToListAsync().ConfigureAwait(false);
            return 0 == jobs.Count()
                    ? ReturnValue<List<BillingDataIntegrationJob>>.FromError($"Unable to located job for zouraId {zuoraId}")
                    : ReturnValue<List<BillingDataIntegrationJob>>.From(jobs);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<BillingDataIntegrationJob>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<BillingDataIntegrationJob>>> RetrieveJobsByRunDateAsync(DateTime runDate, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var jobs = await this.EnsureContext(context).Jobs.Where(job => job.StartedOn.Date == runDate.Date).ToListAsync().ConfigureAwait(false);
            return 0 == jobs.Count()
                        ? ReturnValue<List<BillingDataIntegrationJob>>.FromError($"Unable to located jobs for Date {runDate.DateOnlyString()}")
                        : ReturnValue<List<BillingDataIntegrationJob>>.From(jobs);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<BillingDataIntegrationJob>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<BillingDataIntegrationJob>>> RetrieveJobTreesByRunDateAsync(DateTime runDate, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var jobs = await this.EnsureContext(context).Jobs
                .Include(j => j.Batches)
                .Where(job => job.StartedOn.Date == runDate.Date).ToListAsync().ConfigureAwait(false);
            return 0 == jobs.Count()
                        ? ReturnValue<List<BillingDataIntegrationJob>>.FromError($"Unable to located jobs for Date {runDate.DateOnlyString()}")
                        : ReturnValue<List<BillingDataIntegrationJob>>.From(jobs);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<BillingDataIntegrationJob>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<BillingDataIntegrationUpdatedAccountBalance>> RetrieveUpdatedAccountBalanceByIdAsync(int id, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var accountBalance = await this.EnsureContext(context).UpdatedAccountBalances.FirstOrDefaultAsync(uac => uac.Id.Equals(id)).ConfigureAwait(false);
            return null == accountBalance
                ? ReturnValue<BillingDataIntegrationUpdatedAccountBalance>.FromError($"Unable to find balance for Id {id}")
                : ReturnValue<BillingDataIntegrationUpdatedAccountBalance>.From(accountBalance);
        }
        catch (Exception ex)
        {
            return ReturnValue<BillingDataIntegrationUpdatedAccountBalance>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<BillingDataIntegrationUpdatedAccountBalance>>> RetrieveUpdatedAccountBalancesByZuoraIdAsync(string zuoraId, BillingDataIntegrationContext? context = null)
    {
        try
        {
            var accountBalances = await this.EnsureContext(context).UpdatedAccountBalances.Where(uac => uac.AccountId == zuoraId).ToListAsync().ConfigureAwait(false);
            return 0 != accountBalances.Count()
                ? ReturnValue<List<BillingDataIntegrationUpdatedAccountBalance>>.From(accountBalances)
                : ReturnValue<List<BillingDataIntegrationUpdatedAccountBalance>>.FromError($"Unable to find account balances by zuoraid {zuoraId}");
        }
        catch (Exception ex)
        {
            return ReturnValue<List<BillingDataIntegrationUpdatedAccountBalance>>.FromError(ex);
        }
    }
}