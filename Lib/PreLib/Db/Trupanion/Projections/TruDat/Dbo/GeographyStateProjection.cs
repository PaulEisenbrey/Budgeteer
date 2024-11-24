using Utilities.Constants.Enum;
using Utilities.EntityBaseClasses;
using Utilities.Extension;

namespace Database.Trupanion.Projections.TruDat.Dbo;

public class GeographyStateProjection : EntityIntId
{
    public int CountryId { get; set; }

    public string StateCode { get; set; } = "";

    public string Name { get; set; } = "";

    public TrupStates StateEnum => (TrupStates)Id;

    public CountryCodeEx CountryEnum => (CountryCodeEx)CountryId;

    public override string ToString()
    {
        return $"{Name} {((CountryCodeEx)CountryId).Description()}: {StateCode} : {Id}";
    }
}
