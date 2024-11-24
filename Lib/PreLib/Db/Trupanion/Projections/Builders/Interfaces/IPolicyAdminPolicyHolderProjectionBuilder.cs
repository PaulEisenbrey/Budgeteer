using Database.Trupanion.Projections.TruDat.PolicyAdmin;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders.Interfaces;

public interface IPolicyAdminPolicyHolderProjectionBuilder
{
    Task<ReturnValue<PolicyAdminPolicyHolderProjectionBuilder>> InitializeByPersonId(Guid personId);

    TruDatPolicyAdminPolicyHolderProjection Build { get; }
}