using Utilities.Constants.Enum;
using Utilities.ReturnType;
using Database.Trupanion.Entity;
using Database.Trupanion.Projections.TruDat.Dbo;

namespace Database.Trupanion.Projections.Builders.Interfaces;

public interface IBreedProjectionBuilder
{
    Task<ReturnValue<BreedProjectionBuilder>> InitializeByBreedId(int breedId);
    Task<ReturnValue<BreedProjectionBuilder>> InitializeByBreedName(string breedName);
    int? BreedId { get; }

    string? BreedName { get; }

    Species Species { get; }

    TruDatDboBreedProjection Build { get; }
}
