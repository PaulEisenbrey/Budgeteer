using Database.Trupanion.Entity.TruDat.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders.Interfaces;

public interface IClinicBuilder
{
    Task<ReturnValue<ClinicBuilder>> InitializeById(int hospitalId);

    TruDatDboClinic Build { get; }
}