namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboBankCheck
{
    public int Id { get; set; }
    public int ClaimId { get; set; }
    public int StatusId { get; set; }
    public decimal Amount { get; set; }
    public int? IssuedByUserId { get; set; }
    public int? CancelledByUserId { get; set; }
    public DateTime? DateCancelled { get; set; }
    public string? PayableTo { get; set; }
    public DateTime? DateCleared { get; set; }
    public int? RequestedByUserId { get; set; }
    public DateTime? DateRequested { get; set; }
    public string? StopReason { get; set; }
    public string? Comments { get; set; }
    public int? AccountId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public int? EntityPaymentGroupId { get; set; }

    public virtual TruDatDboAccount? Account { get; set; }
    public virtual TruDatDboUser? CancelledByUser { get; set; }
    public virtual TruDatDboClaim? Claim { get; set; }
    public virtual TruDatDboUser? IssuedByUser { get; set; }
    public virtual TruDatDboUser? RequestedByUser { get; set; }
    public virtual TruDatDboStatus? Status { get; set; }
}
