namespace Database.Trupanion.Entity.Workflow;

public class WFDboConversationTopicList
{
    public int Id { get; set; }
    public int ConversationId { get; set; }
    public int ConversationTopicId { get; set; }

    public virtual WFDboConversation? Conversation { get; set; }
    public virtual WFDboConversationTopic? ConversationTopic { get; set; }
}
