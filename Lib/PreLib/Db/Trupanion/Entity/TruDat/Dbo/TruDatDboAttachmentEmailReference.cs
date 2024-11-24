namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAttachmentEmailReference
{
    public int Id { get; set; }
    public Guid ReferenceId { get; set; }
    public string? EmailAddress { get; set; }
    public int? AttachmentEmailId { get; set; }
    public int? FailedDeliveryCategoryId { get; set; }
    public int? FailedDeliveryCode { get; set; }
    public string? FailedDeliveryExplanation { get; set; }
    public int? TemplateId { get; set; }
    public int ChangeUserId { get; set; }
    public int? AboutEntityTypeId { get; set; }
    public int? AboutEntityId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? DocumentId { get; set; }
    public int? DocumentTemplateDefinitionId { get; set; }

    public virtual TruDatDboEntity? AboutEntityType { get; set; }
    public virtual TruDatDboAttachmentEmail? AttachmentEmail { get; set; }
    public virtual TruDatDboUser? ChangeUser { get; set; }
}
