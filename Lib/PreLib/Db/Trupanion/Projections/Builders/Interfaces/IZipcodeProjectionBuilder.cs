using Database.Trupanion.Projections.TruDat.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders.Interfaces;

public interface IZipcodeProjectionBuilder
{
    Task<ReturnValue<ZipcodeProjectionBuilder>> RetrieveZipCodeProjectionByZipcode(string zipcode);

    TruDatDboZipcodeProjection Build { get; }
}