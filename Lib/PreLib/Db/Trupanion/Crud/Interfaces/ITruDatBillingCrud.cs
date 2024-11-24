using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.TruDat.Claim;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface ITruDatBillingCrud : IQaLibCrud
{
    Task<ReturnValue<TruDatBillingAmazonBillingAgreement>> RetrieveAmazonBillingAgreementByOwnerIdAsync(int ownerId, TruDatBillingContext? context = null);
    Task<ReturnValue<TruDatBillingAssociateBankAccount>> RetrieveAmazonBillingAssociateBankAccountByAssociateIdAsync(int associateId, TruDatBillingContext? context = null);
}