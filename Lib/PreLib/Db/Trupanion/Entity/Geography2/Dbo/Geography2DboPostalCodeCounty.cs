namespace Database.Trupanion.Entity.Geography2.Dbo;

public  class Geography2DboPostalCodeCounty
{
    public int Id { get; set; }
    public int CountyId { get; set; }
    public int PostalCodeId { get; set; }

    public virtual Geography2DboCounty? County { get; set; }
    public virtual Geography2DboPostalCode? PostalCode { get; set; }
}
