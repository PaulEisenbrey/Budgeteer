namespace Database.Trupanion.Entity.Geography2.Dbo;

public  class Geography2DboPostalCodeCity
{
    public int Id { get; set; }
    public int CityId { get; set; }
    public int PostalCodeId { get; set; }

    public virtual Geography2DboCity? City { get; set; }
    public virtual Geography2DboPostalCode? PostalCode { get; set; }
}
