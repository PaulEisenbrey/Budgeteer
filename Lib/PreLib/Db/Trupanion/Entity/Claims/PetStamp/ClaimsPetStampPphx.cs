namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampPphx
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public byte[]? ConcurrencyToken { get; set; }
    public int PetId { get; set; }
    public int PphxTypeId { get; set; }
    public string? Notes { get; set; }
    public bool IsVerified { get; set; }
    public DateTime? VerifiedOn { get; set; }
    public Guid? VerifiedBy { get; set; }

    public virtual ClaimsPetStampPphxType? PphxType { get; set; }
    public virtual List<ClaimsPetStampPphxHistory> PphxHistories { get; set; } = new();
    public virtual List<ClaimsPetStampPphxItemSelectionHistory> PphxItemSelectionHistories { get; set; } = new();
    public virtual List<ClaimsPetStampPphxItemSelection> PphxItemSelections { get; set; } = new();
}
