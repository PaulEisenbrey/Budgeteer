using System.Linq.Expressions;

using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.TruDat.PolicyAdmin;
using Database.Trupanion.Projections.Builders.Interfaces;
using Utilities.ArgumentEvaluation;
using Utilities.Extension.StringExtension;
using Utilities.IoCInterfaces;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders;

public class PolicyAdminPolicyHolderBuilder
 :
    BuilderBase<TruDatPolicyAdminPolicyHolder>
    , IBuilder<TruDatPolicyAdminPolicyHolder>
    , IBuildable
    , IPolicyAdminPolicyHolderBuilder
    , ITransientSvc
{
    private readonly ITruDatPolicyAdminCrud? policyAdminCrud;
    private readonly IContextGenerator crudBase;

    public PolicyAdminPolicyHolderBuilder(ITruDatPolicyAdminCrud crudInst, IContextGenerator crudBase)
    {
        this.policyAdminCrud = crudInst;
        this.crudBase = crudBase;
    }

    public async Task<ReturnValue<PolicyAdminPolicyHolderBuilder>> InitializeByPersonId(Guid personId)
    {
        EvaluateArgument.Execute(this.policyAdminCrud, fn => null != this.policyAdminCrud, "Unable to generate database crud class");
        var ctx = this.crudBase.GenerateTruDatPolicyAdminContext();

        Expression<Func<TruDatPolicyAdminPolicyHolder, bool>> predicate = ph => ph.Id == personId;
        var policyHolder = await policyAdminCrud!.RetrieveByQueryAsync(predicate, ctx).ConfigureAwait(false);

        EvaluateArgument.Execute(policyHolder,
            fn => null != policyHolder && policyHolder.IsValid && null != policyHolder.Result,
            policyHolder.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for policyholder query but no error message");

        this._entity = policyHolder.Result!;

        return ReturnValue<PolicyAdminPolicyHolderBuilder>.From(this);
    }
}