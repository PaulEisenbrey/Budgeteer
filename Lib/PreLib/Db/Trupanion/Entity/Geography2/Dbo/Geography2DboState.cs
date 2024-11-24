namespace Database.Trupanion.Entity.Geography2.Dbo;

public  class Geography2DboState
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public string StateCode { get; set; } = "";
    public string Name { get; set; } = "";

    public virtual Geography2DboCountry? Country { get; set; }
    public virtual List<Geography2DboCity> Cities { get; set; } = new();
    public virtual List<Geography2DboCounty> Counties { get; set; } = new();
    public virtual List<Geography2DboPostalCodeState> PostalCodeStates { get; set; } = new();
}
