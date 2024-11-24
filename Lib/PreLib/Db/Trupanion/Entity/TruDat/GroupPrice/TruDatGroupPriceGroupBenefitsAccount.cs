namespace Database.Trupanion.Entity.TruDat.GroupPrice;

public class TruDatGroupPriceGroupBenefitsAccount
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid UniqueId { get; set; }
    public int CorporateAccountId { get; set; }
    public DateTime PolicyInceptionDate { get; set; }
    public DateTime? PolicyCancelationDate { get; set; }
    public string? GroupId { get; set; }
    public int PolicyVersionImplementationId { get; set; }
    public int GroupPriceEngineVersionId { get; set; }
    public int? CoreRenewalMonth { get; set; }
    public int? CoreRenewalYear { get; set; }

    public virtual TruDatGroupPriceEngineVersion? GroupPriceEngineVersion { get; set; }
    public virtual TruDatGroupPricePolicyVersionImplementation? PolicyVersionImplementation { get; set; }
}
