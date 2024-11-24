namespace Database.Trupanion.Entity.Workflow;

public class WFDboConversationActivity
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public int ConversationId { get; set; }
    public int ConversationActionId { get; set; }
    public Guid UserId { get; set; }

    public virtual WFDboConversation? Conversation { get; set; }
    public virtual WFDboConversationAction? ConversationAction { get; set; }
}
