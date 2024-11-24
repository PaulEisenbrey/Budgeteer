namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampProcessVerificationStatus
{
    public ClaimsPetStampProcessVerificationStatus()
    {
        ProcessVerifications = new HashSet<ClaimsPetStampProcessVerification>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ClaimsPetStampProcessVerification> ProcessVerifications { get; set; }
}
