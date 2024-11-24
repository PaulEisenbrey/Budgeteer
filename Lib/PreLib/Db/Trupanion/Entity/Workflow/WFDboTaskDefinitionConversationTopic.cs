namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskDefinitionConversationTopic
{
    public int Id { get; set; }
    public int TaskDefinitionId { get; set; }
    public int ConversationTopicId { get; set; }

    public virtual WFDboConversationTopic? ConversationTopic { get; set; }
    public virtual WFDboTaskDefinition? TaskDefinition { get; set; }
}
