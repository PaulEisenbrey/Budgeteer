using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Projections.Builders.Interfaces;
using Database.Trupanion.Projections.TruDat.Dbo;
using Utilities.IoCInterfaces;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders;

public class ClinicProjectionBuilder : BuilderBase<TruDatDboClinicProjection>, IBuilder<TruDatDboClinicProjection>, IBuildable, IClinicProjectionBuilder, ITransientSvc
{
    private readonly ITruDatDboProjectionCrud crud;
    private readonly IContextGenerator crudBase;

    public ClinicProjectionBuilder(ITruDatDboProjectionCrud tdCrud, IContextGenerator crudBase)
    {
        this.crud = tdCrud;
        this.crudBase = crudBase;
    }

    public async Task<ReturnValue<ClinicProjectionBuilder>> InitializeById(int clinicId)
    {
        var ctx = this.crudBase.GenerateTruDatDBOContext();

        var clinic = await crud.RetrieveClinicProjectionByIdAsync(clinicId, ctx).ConfigureAwait(false);

        this._entity = clinic.IsValid && null != clinic.Result ? clinic.Result : this._entity;

        return !clinic.IsValid
            ? ReturnValue<ClinicProjectionBuilder>.FromError(clinic.ErrorText)
            : null == clinic.Result
                ? ReturnValue<ClinicProjectionBuilder>.FromError($"Retrieved NULL from database for Clinic Id {clinicId}")
                : ReturnValue<ClinicProjectionBuilder>.From(this);
    }
}