namespace Database.Trupanion.Entity.TruDat.PolicyAdmin;

public class TruDatPolicyAdminPendingPolicyChange
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid? BrandId { get; set; }
    public string? PolicyNumber { get; set; }
    public Guid? PrimaryPolicyholderId { get; set; }
    public string? AlternatePolicyholders { get; set; }
}
