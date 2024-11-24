namespace Database.Trupanion.Entity.TruDat.GroupPrice;

public class TruDatGroupPricePolicyVersionImplementationDeductible
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int PolicyVersionImplementationId { get; set; }
    public int CoverageDeductibleId { get; set; }

    public virtual TruDatGroupPricePolicyVersionImplementation? PolicyVersionImplementation { get; set; }
    public virtual List<TruDatGroupPriceEngineVersionPremium> EngineVersionPremia { get; set; } = new();
}
