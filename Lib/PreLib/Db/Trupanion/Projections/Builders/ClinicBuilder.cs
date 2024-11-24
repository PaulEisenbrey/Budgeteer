using System.Linq.Expressions;

using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.TruDat.Dbo;
using Database.Trupanion.Projections.Builders.Interfaces;
using Utilities.ArgumentEvaluation;
using Utilities.IoCInterfaces;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders;

public class ClinicBuilder : BuilderBase<TruDatDboClinic>, IBuilder<TruDatDboClinic>, IBuildable, IClinicBuilder, ITransientSvc
{
    private readonly ITruDatDboProjectionCrud crud;
    private readonly IContextGenerator crudBase;

    public ClinicBuilder(ITruDatDboProjectionCrud tdCrud, IContextGenerator crudBase)
    {
        this.crud = tdCrud;
        this.crudBase = crudBase;
    }

    public async Task<ReturnValue<ClinicBuilder>> InitializeById(int hospitalId)
    {
        EvaluateArgument.Execute(this.crud, fn => null != this.crud, "Unable to instantiate Database Crud");
        var ctx = this.crudBase.GenerateTruDatDBOContext();

        Expression<Func<TruDatDboClinic, bool>> predicate = fn => fn.Id == hospitalId;
        var clinic = await crud.RetrieveByQueryAsync(predicate, ctx).ConfigureAwait(false);

        this._entity = clinic.IsValid && null != clinic.Result ? clinic.Result : this._entity;

        return !clinic.IsValid
            ? ReturnValue<ClinicBuilder>.FromError(clinic.ErrorText)
            : null == clinic.Result
                ? ReturnValue<ClinicBuilder>.FromError($"Retrieved NULL from database for Clinic Id {hospitalId}")
                : ReturnValue<ClinicBuilder>.From(this);
    }
}