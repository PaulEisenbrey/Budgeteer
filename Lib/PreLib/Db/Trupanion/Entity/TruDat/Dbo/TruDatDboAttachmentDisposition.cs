namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAttachmentDisposition
{
    public int Id { get; set; }
    public int AttachmentId { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public int? AssignedUserId { get; set; }
    public int UserId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? PageNumber { get; set; }

    public virtual TruDatDboUser? AssignedUser { get; set; }
    public virtual TruDatDboAttachment? Attachment { get; set; }
    public virtual TruDatDboEntity? EntityType { get; set; }
    public virtual TruDatDboUser? User { get; set; }
}
