namespace Database.Trupanion.Entity.TruDat.PolicyAdmin;

public class TruDatPolicyAdminPetPolicyRenewalSchedulingFailure
{
    public Guid Id { get; set; }
    public Guid? PetPolicyId { get; set; }
    public bool IsTransient { get; set; }
    public int RetryCount { get; set; }
    public string? ExceptionDetail { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public string? ExceptionType { get; set; }
}
