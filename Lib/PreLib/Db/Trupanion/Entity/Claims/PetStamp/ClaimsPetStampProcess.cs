namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampProcess
{
    public ClaimsPetStampProcess()
    {
        ProcessVerifications = new HashSet<ClaimsPetStampProcessVerification>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public byte[]? ConcurrencyToken { get; set; }
    public int PetId { get; set; }
    public bool IsFullyVerified { get; set; }

    public virtual ICollection<ClaimsPetStampProcessVerification> ProcessVerifications { get; set; }
}
