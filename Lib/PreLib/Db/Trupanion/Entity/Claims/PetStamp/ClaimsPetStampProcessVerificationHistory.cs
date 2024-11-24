namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampProcessVerificationHistory
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public int ProcessVerificationId { get; set; }
    public int ProcessId { get; set; }
    public int ItemId { get; set; }
    public bool IsVerified { get; set; }
    public DateTime? VerifiedOn { get; set; }
    public Guid? VerifiedBy { get; set; }
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
    public DateTime? DateOn { get; set; }
    public int? Status { get; set; }
    public int? DateTypeId { get; set; }
    public string? Notes { get; set; }

    public virtual ClaimsPetStampProcessVerification? ProcessVerification { get; set; }
    public virtual List<ClaimsPetStampProcessVerificationHospitalHistory> ProcessVerificationHospitalHistories { get; set; } = new();
}
