using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.TruDat.Dbo;
using Database.Trupanion.Projections.Builders.Interfaces;
using Utilities.ArgumentEvaluation;
using Utilities.Extension.StringExtension;
using Utilities.IoCInterfaces;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders;

public class OwnerBuilder : BuilderBase<TruDatDboOwner>, IBuilder<TruDatDboOwner>, IBuildable, IOwnerBuilder, ITransientSvc
{
    private readonly ITruDatDboCrud? trudatdbocrud;

    public OwnerBuilder(ITruDatDboCrud tdCrud) =>
        trudatdbocrud = tdCrud;

    public async Task<ReturnValue<OwnerBuilder>> InitializeByOwnerId(int ownerId)
    {
        EvaluateArgument.Execute(this.trudatdbocrud, fn => null != this.trudatdbocrud, "Unable to instantiate Database Crud");
        var owner = await trudatdbocrud!.RetrieveOwnerByIdAsync(ownerId).ConfigureAwait(false);

        EvaluateArgument.Execute(owner, fn => null != owner && owner.IsValid && null != owner.Result,
            owner.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for owner query but no error message");

        this._entity = owner.Result!;

        return ReturnValue<OwnerBuilder>.From(this);
    }

    public async Task<ReturnValue<OwnerBuilder>> InitializeByPolicyNumber(string policyNumber)
    {
        EvaluateArgument.Execute(this.trudatdbocrud, fn => null != this.trudatdbocrud, "Unable to instantiate Database Crud");
        var owner = await trudatdbocrud!.RetrieveOwnerByPolicyNumberAsync(policyNumber).ConfigureAwait(false);

        EvaluateArgument.Execute(owner,
            fn => null != owner && owner.IsValid && null != owner.Result,
            owner.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for owner query but no error message");

        this._entity = owner.Result!;

        return ReturnValue<OwnerBuilder>.From(this);
    }

    public async Task<ReturnValue<OwnerBuilder>> InitializeByEmailAddress(string emailAddress)
    {
        EvaluateArgument.Execute(this.trudatdbocrud, fn => null != this.trudatdbocrud, "Unable to instantiate Database Crud");
        var owner = await trudatdbocrud!.RetrieveOwnerByEmailAsync(emailAddress).ConfigureAwait(false);

        EvaluateArgument.Execute(owner,
            fn => null != owner && owner.IsValid && null != owner.Result,
            owner.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for owner query but no error message");

        this._entity = owner.Result!;

        return ReturnValue<OwnerBuilder>.From(this);
    }

    public async Task<ReturnValue<OwnerBuilder>> InitializeByPersonId(Guid personId)
    {
        EvaluateArgument.Execute(this.trudatdbocrud, fn => null != this.trudatdbocrud, "Unable to instantiate Database Crud");
        var owner = await trudatdbocrud!.RetrieveOwnerByPersonIdAsync(personId).ConfigureAwait(false);

        EvaluateArgument.Execute(owner,
            fn => null != owner && owner.IsValid && null != owner.Result,
            owner.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for owner query but no error message");

        this._entity = owner.Result!;

        return ReturnValue<OwnerBuilder>.From(this);
    }
}