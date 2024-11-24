namespace Database.Trupanion.Entity.TruDat.GroupPrice;

public class TruDatGroupPriceAgeGroupConfiguration
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
    public bool Active { get; set; }

    public virtual List<TruDatGroupPriceAgeGroupFactor> AgeGroupFactors { get; set; } = new();
    public virtual List<TruDatGroupPriceEngineVersionModel> EngineVersionModels { get; set; } = new();
}
