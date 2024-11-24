using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Projections.Builders.Interfaces;
using Database.Trupanion.Projections.TruDat.Dbo;
using Utilities.ArgumentEvaluation;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders;

public class ZipcodeProjectionBuilder : BuilderBase<TruDatDboZipcodeProjection>, IBuilder<TruDatDboZipcodeProjection>, IBuildable, IZipcodeProjectionBuilder
{
    private readonly ITruDatDboProjectionCrud? crud;

    public ZipcodeProjectionBuilder(ITruDatDboProjectionCrud crudInstance) => crud = crudInstance;

    public async Task<ReturnValue<ZipcodeProjectionBuilder>> RetrieveZipCodeProjectionByZipcode(string zipcode)
    {
        EvaluateArgument.Execute(this.crud, fn => null != this.crud, "Unable to instantiate Database Crud");
        EvaluateArgument.Execute(zipcode, fn => !string.IsNullOrEmpty(zipcode), "Zipcode must not be an Empty string");

        var zip = await crud!.RetrieveZipcodeProjectionByZipcodeAsync(zipcode).ConfigureAwait(false);

        EvaluateArgument.Execute(zip, fn => null != zip && zip.IsValid && null != zip.Result, $"Unable to find zip code record for {zipcode} [{zip.ErrorText}]");

        this._entity = zip.Result!;

        return ReturnValue<ZipcodeProjectionBuilder>.From(this);
    }
}