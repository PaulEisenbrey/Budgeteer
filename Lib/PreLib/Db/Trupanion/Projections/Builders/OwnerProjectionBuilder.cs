using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.Aggregates;
using Database.Trupanion.Projections.Builders.Interfaces;
using Database.Trupanion.Projections.TruDat.Dbo;
using Utilities.ArgumentEvaluation;
using Utilities.Extension.StringExtension;
using Utilities.IoCInterfaces;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders;

public class OwnerProjectionBuilder : BuilderBase<OwnerCollection>, IBuilder<OwnerCollection>, IBuildable, IOwnerProjectionBuilder, ITransientSvc
{
    private readonly ITruDatDboProjectionCrud trudatdbocrud;
    private readonly ITruDatTruBizCrud trudattrubizcrud;

    public OwnerProjectionBuilder(ITruDatDboProjectionCrud dboCrud, ITruDatTruBizCrud truBizCrud)
    {
        this.trudatdbocrud = dboCrud;
        this.trudattrubizcrud = truBizCrud;
    }

    public async Task<ReturnValue<OwnerProjectionBuilder>> InitializeByOwnerId(int ownerId)
    {
        EvaluateArgument.Execute(this.trudatdbocrud, fn => null != this.trudatdbocrud, "Unable to instantiate Database Crud");
        var ownerProjection = await trudatdbocrud!.RetrieveOwnerProjectionByOwnerIdAsync(ownerId).ConfigureAwait(false);

        EvaluateArgument.Execute(ownerProjection,
            fn => null != ownerProjection && ownerProjection.IsValid && null != ownerProjection.Result,
            ownerProjection.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for owner query but no error message");

        await this.FillOwnerTree(ownerProjection.Result!, trudatdbocrud);

        return ReturnValue<OwnerProjectionBuilder>.From(this);
    }

    public async Task<ReturnValue<OwnerProjectionBuilder>> InitializeByPolicyNumber(string policyNumber)
    {
        EvaluateArgument.Execute(this.trudatdbocrud, fn => null != this.trudatdbocrud, "Unable to instantiate Database Crud");
        var ownerProjection = await trudatdbocrud!.RetrieveOwnerProjectionByPolicyNumberAsync(policyNumber).ConfigureAwait(false);

        EvaluateArgument.Execute(ownerProjection,
            fn => null != ownerProjection && ownerProjection.IsValid && null != ownerProjection.Result,
            ownerProjection.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for owner query but no error message");

        await this.FillOwnerTree(ownerProjection.Result!, trudatdbocrud);

        return ReturnValue<OwnerProjectionBuilder>.From(this);
    }

    public async Task<ReturnValue<OwnerProjectionBuilder>> InitializeByEmailAddress(string emailAddress)
    {
        EvaluateArgument.Execute(this.trudatdbocrud, fn => null != this.trudatdbocrud, "Unable to instantiate Database Crud");
        var ownerProjection = await trudatdbocrud!.RetrieveOwnerProjectionByEMailAddressAsync(emailAddress).ConfigureAwait(false);

        EvaluateArgument.Execute(ownerProjection,
            fn => null != ownerProjection && ownerProjection.IsValid && null != ownerProjection.Result,
            ownerProjection.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for owner query but no error message");

        await this.FillOwnerTree(ownerProjection.Result!, trudatdbocrud);

        return ReturnValue<OwnerProjectionBuilder>.From(this);
    }

    public async Task<ReturnValue<OwnerProjectionBuilder>> InitializeByPersonId(Guid personId)
    {
        EvaluateArgument.Execute(this.trudatdbocrud, fn => null != this.trudatdbocrud, "Unable to instantiate Database Crud");
        var ownerProjection = await trudatdbocrud!.RetrieveOwnerProjectionByPersonIdAsync(personId).ConfigureAwait(false);

        EvaluateArgument.Execute(ownerProjection,
            fn => null != ownerProjection && ownerProjection.IsValid && null != ownerProjection.Result,
            ownerProjection.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for owner query but no error message");

        await this.FillOwnerTree(ownerProjection.Result!, trudatdbocrud);

        return ReturnValue<OwnerProjectionBuilder>.From(this);
    }

    private async Task FillOwnerTree(TruDatDboOwnerProjection ownerProjection, ITruDatDboProjectionCrud trudatdbocrud)
    {
        var ownerId = ownerProjection.Id;

        var addressProjection = await trudatdbocrud.RetrieveOwnerAddressProjectionByOwnerIdAsync(ownerId);
        EvaluateArgument.Execute(addressProjection,
            fn => null != addressProjection && addressProjection.IsValid && null != addressProjection.Result,
            addressProjection.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for address query but no error message");

        var petProjections = await trudatdbocrud.RetrievePetProjectionsByOwnerIdAsync(ownerId).ConfigureAwait(false);
        EvaluateArgument.Execute(petProjections,
            fn => null != petProjections && petProjections.IsValid && null != petProjections.Result,
            petProjections.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for Pets query but no error message");

        List<PetAndPolicy> pandps = new();

        foreach (var pet in petProjections.Result!)
        {
            var truBizPPolicy = await this.trudattrubizcrud.RetrieveTruBizPetPolicyProjectionByPetIdAsync(pet.Id).ConfigureAwait(false);
            EvaluateArgument.Execute(truBizPPolicy,
                fn => null != truBizPPolicy && truBizPPolicy.IsValid && null != truBizPPolicy.Result,
                truBizPPolicy.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for Pet Policy query but no error message");

            var dboPPolicy = await trudatdbocrud.RetrievePetPolicyProjectionByPetIdAsync(pet.Id).ConfigureAwait(false);
            EvaluateArgument.Execute(dboPPolicy,
                fn => null != dboPPolicy && dboPPolicy.IsValid && null != dboPPolicy.Result,
                dboPPolicy.ErrorText.NullIfEmpty() ?? "Abnormal Error. null response for Dbo Pet Policy query but no error message");

            pandps.Add(new PetAndPolicy().SetPet(pet).SetPetPolicy(truBizPPolicy.Result!).SetDboPetPolicy(dboPPolicy.Result!));
        }

        this._entity = new OwnerCollection().SetOwner(ownerProjection).SetAddress(addressProjection.Result!).AddPetAndPolicies(pandps);
    }
}