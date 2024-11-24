namespace Database.Trupanion.Entity.VisionMigration.CommService;

public class VmCommServiceInteraction
{
    public int Id { get; set; }
    public int Type { get; set; }
    public int ActionType { get; set; }
    public string? Description { get; set; }
    public string? Cause { get; set; }
    public DateTimeOffset ActionDateTime { get; set; }
    public Guid InitiatorReference { get; set; }
    public int? CustomerId { get; set; }
    public int BrandId { get; set; }
    public int? CommunicationDocumentDataId { get; set; }
    public Guid CommunicationId { get; set; }
    public Guid CustomerReference { get; set; }
}
