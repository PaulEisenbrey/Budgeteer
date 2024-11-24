namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPartnerProjection
{
    public int PartnerId { get; set; }
    public int Month { get; set; }
    public int New { get; set; }
    public int Cancel { get; set; }
    public int Book { get; set; }
    public decimal? Factor { get; set; }
}
