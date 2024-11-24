namespace Database.Trupanion.Entity.TruDat.Price;

public class TruDatPriceRateValue
{
    public int Id { get; set; }
    public int EngineId { get; set; }
    public int VersionId { get; set; }
    public int AnimalId { get; set; }
    public int RateId { get; set; }
    public double Rate { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public Guid UniqueId { get; set; }

    public virtual TruDatPriceEngine? Engine { get; set; }
    public virtual TruDatPriceRate? RateNavigation { get; set; }
    public virtual TruDatPriceEngineVersion? Version { get; set; }
}
