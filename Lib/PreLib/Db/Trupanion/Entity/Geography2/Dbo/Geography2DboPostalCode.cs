namespace Database.Trupanion.Entity.Geography2.Dbo;

public class Geography2DboPostalCode
{
    public int Id { get; set; }
    public string Code { get; set; } = "";
    public int CountryId { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }

    public virtual Geography2DboCountry? Country { get; set; }
    public virtual List<Geography2DboPostalCodeCity> PostalCodeCities { get; set; } = new();
    public virtual List<Geography2DboPostalCodeCounty> PostalCodeCounties { get; set; } = new();
    public virtual List<Geography2DboPostalCodeState> PostalCodeStates { get; set; } = new();
}
