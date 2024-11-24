using Database.Trupanion.Entity.TruDat.Dbo;

namespace Database.Trupanion.Projections.TruDat.Dbo;

public class TruDatDboZipcodeProjection
{
    public string? Zipcode1 { get; set; }
    public int StateId { get; set; }
    public string? PlaceName { get; set; }
    public string? County { get; set; }
    public decimal? Lat { get; set; }
    public decimal? Lon { get; set; }
    public bool? Active { get; set; }
}
