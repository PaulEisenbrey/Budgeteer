namespace Database.Trupanion.Entity.TruDat.GroupPrice;

public class TruDatGroupPriceEngineVersionConfiguration
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid UniqueId { get; set; }
    public string? Name { get; set; }
    public string? Comments { get; set; }
    public int GroupPriceEngineVersionModelId { get; set; }
    public double GroupAvgAgeSpecieFactor { get; set; }
    public int? GroupPricePolicyVersionImplementationId { get; set; }
    public string? DeductibleList { get; set; }
    public string? DeductibleAvgPremiumList { get; set; }
    public bool? UseCurrentAge { get; set; }
    public bool Active { get; set; }

    public virtual TruDatGroupPriceEngineVersionModel? GroupPriceEngineVersionModel { get; set; }
    public virtual TruDatGroupPricePolicyVersionImplementation? GroupPricePolicyVersionImplementation { get; set; }
    public virtual List<TruDatGroupPriceEngineVersion> EngineVersions { get; set; } = new();
}
