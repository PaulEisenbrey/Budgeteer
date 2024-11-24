namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityListPetCo
{
    public int EntityListId { get; set; }
    public int? StoreNumber { get; set; }
    public string? StoreName { get; set; }
    public int? Zone { get; set; }
    public int? Dist { get; set; }
    public int? Cocd { get; set; }
    public int? MainDc { get; set; }
    public int? RegionalDc { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? County { get; set; }
    public string? StateCode { get; set; }
    public string? FullZip { get; set; }
    public string? Zipcode { get; set; }
    public string? ManagerName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? FaxNumber { get; set; }
    public int? SqFt { get; set; }
    public string? Format { get; set; }
    public string? FormatDesc { get; set; }
    public DateTime? DateOpened { get; set; }
    public DateTime? DateRemodeled { get; set; }
    public DateTime? ExpOpen { get; set; }
    public string? StoreClass { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboEntityList? EntityList { get; set; }
}
