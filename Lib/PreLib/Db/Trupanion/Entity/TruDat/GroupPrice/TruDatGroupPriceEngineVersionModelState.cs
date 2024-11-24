namespace Database.Trupanion.Entity.TruDat.GroupPrice;

public class TruDatGroupPriceEngineVersionModelState
{
    public int Id { get; set; }
    public int GroupPriceEngineVersionModelId { get; set; }
    public int StateId { get; set; }
    public int EffectiveYear { get; set; }
    public byte EffectiveMonth { get; set; }
    public DateTime Inserted { get; set; }
    public int? CapPercent { get; set; }

    public virtual TruDatGroupPriceEngineVersionModel? GroupPriceEngineVersionModel { get; set; }
}
