namespace Database.Trupanion.Entity.Workflow;

public class WFDboConversationParticipant
{
    public int Id { get; set; }
    public int ConversationId { get; set; }
    public Guid UserId { get; set; }
    public bool Actionable { get; set; }

    public virtual WFDboConversation? Conversation { get; set; }
}
