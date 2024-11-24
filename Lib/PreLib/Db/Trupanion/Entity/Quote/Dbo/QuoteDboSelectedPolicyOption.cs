namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboSelectedPolicyOption
{
    public int Id { get; set; }
    public int QuotePetId { get; set; }
    public string? Name { get; set; }
    public decimal Cost { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int CoveragePackageId { get; set; }

    public virtual QuoteDboQuotePet? QuotePet { get; set; }
}
