namespace Database.Trupanion.Entity.Workflow;

public class WFDboConversationExchange
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int ConversationId { get; set; }
    public string Content { get; set; } = "";

    public virtual WFDboConversation? Conversation { get; set; }
}
