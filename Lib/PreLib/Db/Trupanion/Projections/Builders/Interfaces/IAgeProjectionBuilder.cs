using Database.Trupanion.Projections.TruDat.Dbo;
using Utilities.Constants.Enum;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders.Interfaces;

public interface IAgeProjectionBuilder
{
    Task<ReturnValue<AgeProjectionBuilder>> InitializeByAgeId(AgeType ageT);
    Task<ReturnValue<AgeProjectionBuilder>> InitializeByAgeName(string name);
    TruDatDboAgeProjection Build { get; }
}
