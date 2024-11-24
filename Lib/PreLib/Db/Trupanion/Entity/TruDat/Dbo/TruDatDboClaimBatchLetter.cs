namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimBatchLetter
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ClaimId { get; set; }
    public int TemplateId { get; set; }
    public string? Body { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? EditableBody { get; set; }
    public int? AssessmentDataId { get; set; }
    public DateTime? LastPrinted { get; set; }
    public int? ClaimStatusLetterId { get; set; }
    public int? DeliveryStatusId { get; set; }
    public int? LastEmailAttachmentId { get; set; }

    public virtual TruDatDboClaim? Claim { get; set; }
    public virtual TruDatDboStatus? DeliveryStatus { get; set; }
    public virtual TruDatDboAttachmentEmail? LastEmailAttachment { get; set; }
    public virtual TruDatDboUser? User { get; set; }
    public virtual List<TruDatDboClaimPrintHistory> ClaimPrintHistories { get; set; } = new();
}
