namespace Database.Trupanion.Entity.TruDat.GroupPrice;

public class TruDatGroupPriceEngineVersionPremium
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int SpecieId { get; set; }
    public int PolicyVersionImplementationDeductibleId { get; set; }
    public int AgeGroupId { get; set; }
    public int GroupPriceEngineVersionId { get; set; }
    public decimal Premium { get; set; }

    public virtual TruDatGroupPriceAgeGroup? AgeGroup { get; set; }
    public virtual TruDatGroupPriceEngineVersion? GroupPriceEngineVersion { get; set; }
    public virtual TruDatGroupPricePolicyVersionImplementationDeductible? PolicyVersionImplementationDeductible { get; set; }
}
