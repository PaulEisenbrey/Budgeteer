namespace Database.Trupanion.Entity.TruDat.GroupPrice;

public class TruDatGroupPriceEngineVersionModel
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid UniqueId { get; set; }
    public int? AgeGroupConfigurationId { get; set; }
    public string? Name { get; set; }
    public string? Comments { get; set; }
    public DateTime EffectiveDate { get; set; }
    public bool Active { get; set; }

    public virtual TruDatGroupPriceAgeGroupConfiguration? AgeGroupConfiguration { get; set; }
    public virtual List<TruDatGroupPriceEngineVersionConfiguration> EngineVersionConfigurations { get; set; } = new();
    public virtual List<TruDatGroupPriceEngineVersionModelState> EngineVersionModelStates { get; set; } = new();
}
