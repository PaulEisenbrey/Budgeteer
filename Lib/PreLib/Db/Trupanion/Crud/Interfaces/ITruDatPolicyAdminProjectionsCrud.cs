using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Projections.TruDat.PolicyAdmin;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface ITruDatPolicyAdminProjectionsCrud : IQaLibCrud
{
    Task<ReturnValue<List<TruDatPolicyAdminPolicyHolderProjection>>> RetrievePolicyHolderProjectionsByEmailAsync(string email, TruDatPolicyAdminContext? context = null);
    Task<ReturnValue<TruDatPolicyAdminPolicyHolderProjection>> RetrievePolicyHolderProjectionsByPersonIdAsync(Guid personId, TruDatPolicyAdminContext? context = null);
}