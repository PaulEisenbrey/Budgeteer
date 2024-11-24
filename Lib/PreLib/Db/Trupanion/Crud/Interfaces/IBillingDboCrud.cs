using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.Billing.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface IBillingDboCrud : IQaLibCrud
{
    Task<ReturnValue<BillingDboAccount>> RetrieveAccountByZuoraIdAsync(string zuoraId, BillingDboContext? dboContext = null);
    Task<ReturnValue<BillingDboAccountPolicyholder>> RetrieveAccountPolicyHolderByOwnerIdAsync(int ownerId, BillingDboContext? dboContext = null);
    Task<ReturnValue<BillingDboAccountPolicyholder>> RetrieveAccountPolicyHolderByOwnerUniqueIdAsync(Guid unqueId, BillingDboContext? dboContext = null);
    Task<ReturnValue<BillingDboAccountPolicyholder>> RetrieveAccountPolicyHolderTreeByOwnerIdAsync(int ownerId, BillingDboContext? dboContext = null);
    Task<ReturnValue<BillingDboAccountPolicyholder>> RetrieveAccountPolicyHolderTreeByOwnerUniqueIdAsync(Guid ownerUniqueId, BillingDboContext? dboContext = null);
    Task<ReturnValue<BillingDboAccount>> RetrieveAccountTreeByIdAsync(int id, BillingDboContext? dboContext = null);
    Task<ReturnValue<BillingDboAccount>> RetrieveAccountTreeByZuoraIdAsync(string zuoraId, BillingDboContext? dboContext = null);
}