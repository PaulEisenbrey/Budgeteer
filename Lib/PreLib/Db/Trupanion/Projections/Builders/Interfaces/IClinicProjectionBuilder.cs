using Database.Trupanion.Projections.TruDat.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders.Interfaces;

public interface IClinicProjectionBuilder
{
    Task<ReturnValue<ClinicProjectionBuilder>> InitializeById(int clinicId);

    TruDatDboClinicProjection Build { get; }
}