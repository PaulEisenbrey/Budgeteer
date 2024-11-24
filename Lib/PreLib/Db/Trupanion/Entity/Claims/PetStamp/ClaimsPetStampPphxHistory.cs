namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampPphxHistory
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public int PphxId { get; set; }
    public int PetId { get; set; }
    public int PphxTypeId { get; set; }
    public string? Notes { get; set; }
    public bool IsVerified { get; set; }
    public DateTime? VerifiedOn { get; set; }
    public Guid? VerifiedBy { get; set; }

    public virtual ClaimsPetStampPphx? Pphx { get; set; }
}
