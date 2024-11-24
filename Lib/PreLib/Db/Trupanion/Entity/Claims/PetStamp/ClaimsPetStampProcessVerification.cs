namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampProcessVerification
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public byte[]? ConcurrencyToken { get; set; }
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

    public virtual ClaimsPetStampProcessVerificationDateType? DateType { get; set; }
    public virtual ClaimsPetStampItem? Item { get; set; }
    public virtual ClaimsPetStampProcess? Process { get; set; }
    public virtual ClaimsPetStampProcessVerificationStatus? StatusNavigation { get; set; }
    public virtual List<ClaimsPetStampProcessVerificationHistory> ProcessVerificationHistories { get; set; } = new();
    public virtual List<ClaimsPetStampProcessVerificationHospital> ProcessVerificationHospitals { get; set; } = new();
}
