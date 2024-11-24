namespace Database.Trupanion.Entity.VisionMigration.CommService;

public class VmCommServiceCommunication
{
    public int Id { get; set; }
    public Guid Reference { get; set; }
    public int Status { get; set; }
    public int Type { get; set; }
    public string? Subject { get; set; }
    public string? SenderAddress { get; set; }
    public string? RecipientAddress { get; set; }
    public int InteractionId { get; set; }
    public string? RecipientState { get; set; }
    public int CustomerId { get; set; }
    public string? CommunicationDocumentBody { get; set; }
    public Guid CustomerReference { get; set; }
    public string? CommunicationAttachments { get; set; }
    public int BodyContentItemId { get; set; }
}
