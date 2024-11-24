namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAttachmentEmail
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? EntityId { get; set; }
    public int? EntityTypeId { get; set; }
    public string? EmailBody { get; set; }
    public DateTime? Inserted { get; set; }
    public DateTime? Updated { get; set; }
    public int? UserId { get; set; }
    public bool? IsBounceBack { get; set; }

    public virtual List<TruDatDboAttachmentEmailReference> AttachmentEmailReferences { get; set; } = new();
    public virtual List<TruDatDboClaimBatchLetter> ClaimBatchLetters { get; set; } = new();
}
