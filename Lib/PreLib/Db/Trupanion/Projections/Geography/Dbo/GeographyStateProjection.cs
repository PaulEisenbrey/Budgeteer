using Utilities.Constants.Enum;
using Utilities.EntityBaseClasses;
using Utilities.Extension;

namespace Database.Trupanion.Projections.Geography.Dbo;

public class GeographyStateProjection : EntityIntId
{
    public int CountryId { get; set; }

    public string StateCode { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public override string ToString() => $"{this.Name} {((CountryCodeEx)this.CountryId).Description()}: {this.StateCode} : {this.Id}";

    public TrupStates StateEnum => (TrupStates)this.Id;

    public CountryCodeEx CountryEnum => (CountryCodeEx)this.CountryId;

}
