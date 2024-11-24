using Database.Trupanion.Entity.Aggregates;
using Database.Trupanion.Entity.TruDat.PolicyAdmin;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders.Interfaces;

public interface IPolicyAdminPolicyHolderBuilder
{
    Task<ReturnValue<PolicyAdminPolicyHolderBuilder>> InitializeByPersonId(Guid personId);

    TruDatPolicyAdminPolicyHolder Build { get;  }
}
