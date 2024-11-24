namespace Database.Trupanion.Entity.Geography2.Dbo;

public class Geography2DboCity
{
    public int Id { get; set; }
    public int StateId { get; set; }
    public string Name { get; set; } = "";

    public virtual Geography2DboState? State { get; set; }
    public virtual List<Geography2DboPostalCodeCity> PostalCodeCities { get; set; } = new();
}
