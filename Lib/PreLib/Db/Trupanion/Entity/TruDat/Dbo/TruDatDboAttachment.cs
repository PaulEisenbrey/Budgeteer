namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAttachment
{
    public int Id { get; set; }
    public string? FileName { get; set; }
    public int InputTypeId { get; set; }
    public int? CategoryId { get; set; }
    public int? DocTypeId { get; set; }
    public string? Source { get; set; }
    public string? Description { get; set; }
    public string? SalesForceId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public bool Active { get; set; }
    public int? InsertUserId { get; set; }
    public string? DocumentId { get; set; }

    public virtual TruDatDboAttachmentCategory? Category { get; set; }
    public virtual TruDatDboAttachmentDocType? DocType { get; set; }
    public virtual TruDatDboAttachmentInputType? InputType { get; set; }
    public virtual TruDatDboAttachmentFaxInfo? AttachmentFaxInfo { get; set; }
    public virtual List<TruDatDboAttachmentDisposition> AttachmentDispositions { get; set; } = new();
}
