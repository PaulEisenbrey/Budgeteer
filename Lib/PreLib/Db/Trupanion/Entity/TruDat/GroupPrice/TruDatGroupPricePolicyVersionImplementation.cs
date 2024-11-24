namespace Database.Trupanion.Entity.TruDat.GroupPrice;

public class TruDatGroupPricePolicyVersionImplementation
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? Name { get; set; }
    public string? Comments { get; set; }
    public Guid UniqueId { get; set; }
    public int? CoveragePolicyVersionId { get; set; }
    public bool Active { get; set; }

    public virtual List<TruDatGroupPriceEngineVersionConfiguration> EngineVersionConfigurations { get; set; } = new();
    public virtual List<TruDatGroupPriceGroupBenefitsAccount> GroupBenefitsAccounts { get; set; } = new();
    public virtual List<TruDatGroupPricePolicyVersionImplementationDeductible> PolicyVersionImplementationDeductibles { get; set; } = new();
    public virtual List<TruDatGroupPricePolicyVersionImplementationRider> PolicyVersionImplementationRiders { get; set; } = new();
    public virtual List<TruDatGroupPricePolicyVersionImplementationWorkingPet> PolicyVersionImplementationWorkingPets { get; set; } = new();
}
