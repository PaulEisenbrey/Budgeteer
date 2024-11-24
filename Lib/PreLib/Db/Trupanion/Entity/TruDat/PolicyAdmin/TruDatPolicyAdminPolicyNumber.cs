namespace Database.Trupanion.Entity.TruDat.PolicyAdmin;

public class TruDatPolicyAdminPolicyNumber
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? BasePolicyNumber { get; set; }
    public int LastPetPolicySuffix { get; set; }
}
