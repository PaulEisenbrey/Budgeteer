namespace Database.Trupanion.Entity.TruDat.GroupPrice;

public class TruDatGroupPriceEngineVersionAgeGroup
{
    public int AgeGroupId { get; set; }
    public int AgeId { get; set; }
    public decimal AgeYearFrom { get; set; }
    public decimal AgeYearTo { get; set; }
    public int EngineVersionId { get; set; }
    public int? EngineVersionConfigurationId { get; set; }
    public int SpecieId { get; set; }
    public bool? UseCurrentAge { get; set; }
}
