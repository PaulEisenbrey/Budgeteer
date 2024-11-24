namespace Database.Trupanion.Entity.TruDat.Price;

public class TruDatPriceFoodFactor
{
    public int Id { get; set; }
    public int EngineId { get; set; }
    public int VersionId { get; set; }
    public int PetFoodId { get; set; }
    public double Factor { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatPriceEngineVersion? Version { get; set; }
}
