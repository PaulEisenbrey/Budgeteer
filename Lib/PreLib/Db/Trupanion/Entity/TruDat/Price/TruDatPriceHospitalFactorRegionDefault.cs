namespace Database.Trupanion.Entity.TruDat.Price;

public class TruDatPriceHospitalFactorRegionDefault
{
    public int Id { get; set; }
    public int RegionId { get; set; }
    public int EngineId { get; set; }
    public int Versionid { get; set; }
    public double? Factor { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}
