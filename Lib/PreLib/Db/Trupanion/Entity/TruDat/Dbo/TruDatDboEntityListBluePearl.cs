namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityListBluePearl
{
    public int EntityListId { get; set; }
    public string? StoreName { get; set; }
    public string? Address1 { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? PhoneNumber { get; set; }

    public virtual TruDatDboEntityList? EntityList { get; set; }
}
