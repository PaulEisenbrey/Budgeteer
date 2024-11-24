namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCurrentStatePricingEngine
{
    public int Id { get; set; }
    public string? StateCode { get; set; }
    public int EngineVersionId { get; set; }
    public int EffectiveYear { get; set; }
    public byte EffectiveMonth { get; set; }
    public int? EffectiveDay { get; set; }
    public int? CapPercent { get; set; }
}
