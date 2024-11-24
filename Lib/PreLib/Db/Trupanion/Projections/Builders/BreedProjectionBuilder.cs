using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Projections.Builders.Interfaces;
using Database.Trupanion.Projections.TruDat.Dbo;
using Utilities.ArgumentEvaluation;
using Utilities.Constants.Enum;
using Utilities.IoCInterfaces;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders;

public class BreedProjectionBuilder : BuilderBase<TruDatDboBreedProjection>, IBuilder<TruDatDboBreedProjection>, IBuildable, IBreedProjectionBuilder, ITransientSvc
{
    private readonly ITruDatDboProjectionCrud crud;

    public BreedProjectionBuilder(ITruDatDboProjectionCrud tdCrud)
    {
        crud = tdCrud;
    }

    public async Task<ReturnValue<BreedProjectionBuilder>> InitializeByBreedId(int breedId)
    {
        EvaluateArgument.Execute(this.crud, fn => null != this.crud, "Unable to instantiate Database Crud");

        var breed = await crud.RetrieveBreedProjectionByIdAsync(breedId).ConfigureAwait(false);

        this._entity = breed.IsValid && null != breed.Result ? breed.Result : this._entity;

        return !breed.IsValid
            ? ReturnValue<BreedProjectionBuilder>.FromError(breed.ErrorText)
            : null == breed.Result
                ? ReturnValue<BreedProjectionBuilder>.FromError($"Retrieved NULL from database for breed Id {breedId}")
                : ReturnValue<BreedProjectionBuilder>.From(this);
    }

    public async Task<ReturnValue<BreedProjectionBuilder>> InitializeByBreedName(string breedName)
    {
        EvaluateArgument.Execute(this.crud, fn => null != this.crud, "Unable to instantiate Database Crud");

        var breed = await crud.RetrieveBreedProjectionByNameAsync(breedName).ConfigureAwait(false);

        this._entity = breed.IsValid && null != breed.Result ? breed.Result : this._entity;

        return !breed.IsValid
            ? ReturnValue<BreedProjectionBuilder>.FromError(breed.ErrorText)
            : null == breed.Result
                ? ReturnValue<BreedProjectionBuilder>.FromError($"Retrieved NULL from database for breed name {breedName}")
                : ReturnValue<BreedProjectionBuilder>.From(this);
    }

    public int? BreedId => this._entity?.Id;

    public string? BreedName => this._entity?.Name;

    public Species Species
    {
        get
        {
            if (null == this._entity)
            {
                return Species.Uninitialized;
            }

            return (Species)this._entity!.AnimalId;
        }
    }
}