namespace Database.Trupanion.Entity.TruDat.Policy;

public class TruDatPolicyEmailRequestStaging
{
    public int Id { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public bool? AttachPolicyDocuments { get; set; }
    public string? Error { get; set; }
    public bool? Active { get; set; }
    public int? Complete { get; set; }
    public string? Body { get; set; }
    public string? ToAddresses { get; set; }
    public string? CcAddresses { get; set; }
    public string? BccAddresses { get; set; }
    public string? FromAddress { get; set; }
    public string? FromDisplayName { get; set; }
    public string? EmailSubject { get; set; }
    public string? Note { get; set; }
    public int? PlatformId { get; set; }
    public DateTime Inserted { get; set; }
    public int? ChangeUserId { get; set; }
    public DateTime? Updated { get; set; }
    public int? AboutEntityId { get; set; }
    public int? AboutEntityTypeId { get; set; }
    public int? CheckedNote { get; set; }
}
