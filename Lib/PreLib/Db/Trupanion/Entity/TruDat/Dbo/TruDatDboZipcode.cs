namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboZipcode
{
    public string? Zipcode1 { get; set; }
    public int StateId { get; set; }
    public long? HtmId { get; set; }
    public string? PlaceName { get; set; }
    public string? County { get; set; }
    public decimal? Lat { get; set; }
    public decimal? Lon { get; set; }
    public bool? Residential { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboState? State { get; set; }
}
