using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Projections.Builders.Interfaces;
using Database.Trupanion.Projections.TruDat.PolicyAdmin;
using Utilities.ArgumentEvaluation;
using Utilities.Extension.StringExtension;
using Utilities.IoCInterfaces;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders;

public class PolicyAdminPolicyHolderProjectionBuilder :
    BuilderBase<TruDatPolicyAdminPolicyHolderProjection>,
    IBuilder<TruDatPolicyAdminPolicyHolderProjection>, IBuildable, IPolicyAdminPolicyHolderProjectionBuilder, ITransientSvc
{
    private readonly ITruDatPolicyAdminProjectionsCrud? crud;

    public PolicyAdminPolicyHolderProjectionBuilder(ITruDatPolicyAdminProjectionsCrud crudInst) => crud = crudInst;

    public async Task<ReturnValue<PolicyAdminPolicyHolderProjectionBuilder>> InitializeByPersonId(Guid personId)
    {
        EvaluateArgument.Execute(this.crud, fn => null != this.crud, "Unable to instantiate Database Crud");

        var policyHolderProjection = await crud!.RetrievePolicyHolderProjectionsByPersonIdAsync(personId).ConfigureAwait(false);

        EvaluateArgument.Execute(policyHolderProjection,
            fn => null != policyHolderProjection && policyHolderProjection.IsValid && null != policyHolderProjection.Result,
            policyHolderProjection.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for policyholder query but no error message");

        this._entity = policyHolderProjection.Result!;

        return ReturnValue<PolicyAdminPolicyHolderProjectionBuilder>.From(this);
    }
}