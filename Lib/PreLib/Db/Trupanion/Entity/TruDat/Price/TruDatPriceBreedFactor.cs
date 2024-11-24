namespace Database.Trupanion.Entity.TruDat.Price;

public partial class TruDatPriceBreedFactor
{
    public int Id { get; set; }
    public int EngineId { get; set; }
    public int VersionId { get; set; }
    public int BreedId { get; set; }
    public double Factor { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public Guid UniqueId { get; set; }

    public virtual TruDatPriceEngineVersion? Version { get; set; }
}
