using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.Billing.DataIntegration;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface IBillingDataIntegrationCrud : IQaLibCrud
{
    Task<ReturnValue<BillingDataIntegrationBatch>> RetrieveBatchByIdAsync(int id, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<List<BillingDataIntegrationBatch>>> RetrieveBatchesByJobIdAsync(int jobId, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<BillingDataIntegrationBatch>> RetrieveBatchTreeByIdAsync(int id, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<List<BillingDataIntegrationBatch>>> RetrieveBatchTreesByJobIdAsync(int jobId, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<BillingDataIntegrationChargeback>> RetrieveChargeBackByIdAsync(int id, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<List<BillingDataIntegrationChargeback>>> RetrieveChargeBacksByZuoraIdAsync(string zuoraId, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<BillingDataIntegrationFailedPayment>> RetrieveFailedPaymentByIdAsync(int id, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<List<BillingDataIntegrationFailedPayment>>> RetrieveFailedPaymentsByZuoraIdAsync(string zuoraId, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<BillingDataIntegrationJob>> RetrieveJobByIdAsync(int id, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<List<BillingDataIntegrationJob>>> RetrieveJobsByRunDateAsync(DateTime runDate, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<List<BillingDataIntegrationJob>>> RetrieveJobsByZuoraIdAsync(string zuoraId, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<BillingDataIntegrationJob>> RetrieveJobTreeByIdAsync(int id, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<List<BillingDataIntegrationJob>>> RetrieveJobTreesByRunDateAsync(DateTime runDate, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<List<BillingDataIntegrationJob>>> RetrieveJobTreesByZuoraIdAsync(string zuoraId, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<BillingDataIntegrationUpdatedAccountBalance>> RetrieveUpdatedAccountBalanceByIdAsync(int id, BillingDataIntegrationContext? context = null);
    Task<ReturnValue<List<BillingDataIntegrationUpdatedAccountBalance>>> RetrieveUpdatedAccountBalancesByZuoraIdAsync(string zuoraId, BillingDataIntegrationContext? context = null);
}