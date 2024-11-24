namespace Database.Trupanion.Entity.TruDat.Policy;

public class TruDatPolicyEmailRequest
{
    public int Id { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public int? DeclarationPageId { get; set; }
    public string? PolicyDocuments { get; set; }
    public bool? AttachPolicyDocuments { get; set; }
    public string? Error { get; set; }
    public int? Complete { get; set; }
    public DateTime? SentTime { get; set; }
    public string? Body { get; set; }
    public string? ToAddresses { get; set; }
    public string? CcAddresses { get; set; }
    public string? BccAddresses { get; set; }
    public string? FromAddress { get; set; }
    public string? FromDisplayName { get; set; }
    public string? EmailSubject { get; set; }
    public int? PlatformId { get; set; }
    public DateTime Inserted { get; set; }
    public int? ChangeUserId { get; set; }
    public DateTime? Updated { get; set; }
    public bool? NoteSaved { get; set; }
    public bool? AttachmentSaved { get; set; }
    public int? DeclarationPageRequestId { get; set; }
    public string? OptionalNote { get; set; }
    public DateTime? SendAfter { get; set; }
}
