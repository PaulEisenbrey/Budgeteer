namespace Database.Trupanion.Entity.TruDat.Price;

public class TruDatPriceEngineVersionState
{
    public int Id { get; set; }
    public int EngineVersionId { get; set; }
    public int StateId { get; set; }
    public int EffectiveYear { get; set; }
    public byte EffectiveMonth { get; set; }
    public DateTime Inserted { get; set; }
    public int? CapPercent { get; set; }
    public Guid UniqueId { get; set; }

    public virtual TruDatPriceEngineVersion? EngineVersion { get; set; }
}
