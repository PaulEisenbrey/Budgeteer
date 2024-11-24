namespace Database.Trupanion.Entity.Geography2.Dbo;

public  class Geography2DboCountry
{
    public int Id { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }
    public string? IsoAlpha2CountryCode { get; set; }
    public string? Name { get; set; }

    public virtual List<Geography2DboPostalCode> PostalCodes { get; set; } = new();
    public virtual List<Geography2DboState> States { get; set; } = new();
}
