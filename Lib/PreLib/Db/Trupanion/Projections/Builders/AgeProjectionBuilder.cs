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

public class AgeProjectionBuilder : BuilderBase<TruDatDboAgeProjection>, IBuilder<TruDatDboAgeProjection>, IBuildable, IAgeProjectionBuilder, ITransientSvc
{
    private readonly ITruDatDboProjectionCrud? crud;

    public AgeProjectionBuilder(ITruDatDboProjectionCrud tdCrud) => crud = tdCrud;

    public async Task<ReturnValue<AgeProjectionBuilder>> InitializeByAgeId(AgeType ageT)
    {
        EvaluateArgument.Execute(this.crud, fn => null != this.crud, "Unable to instantiate Database Crud");

        var age = await crud!.RetrieveAgeProjectionByIdAsync((int)ageT).ConfigureAwait(false);

        this._entity = age.IsValid && null != age.Result ? age.Result : this._entity;

        return !age.IsValid
            ? ReturnValue<AgeProjectionBuilder>.FromError(age.ErrorText)
            : null == age.Result
                ? ReturnValue<AgeProjectionBuilder>.FromError($"Retrieved NULL from database for age {ageT}")
                : ReturnValue<AgeProjectionBuilder>.From(this);
    }

    public async Task<ReturnValue<AgeProjectionBuilder>> InitializeByAgeName(string name)
    {
        EvaluateArgument.Execute(this.crud, fn => null != this.crud, "Unable to instantiate Database Crud");

        var age = await crud!.RetrieveAgeProjectionByNameAsync(name).ConfigureAwait(false);

        this._entity = age.IsValid && null != age.Result ? age.Result : this._entity;

        return !age.IsValid ? ReturnValue<AgeProjectionBuilder>.FromError(age.ErrorText)
            : null == age.Result
            ? ReturnValue<AgeProjectionBuilder>.FromError($"Retrieved NULL from database for age {name}")
            : ReturnValue<AgeProjectionBuilder>.From(this);
    }
}