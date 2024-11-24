namespace Database.Trupanion.Entity.Workflow;

public class WFDboConversationTopic
{
    public WFDboConversationTopic()
    {
        ConversationTopicLists = new HashSet<WFDboConversationTopicList>();
        TaskDefinitionConversationTopics = new HashSet<WFDboTaskDefinitionConversationTopic>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public long? VersionId { get; set; }

    public virtual ICollection<WFDboConversationTopicList> ConversationTopicLists { get; set; }
    public virtual ICollection<WFDboTaskDefinitionConversationTopic> TaskDefinitionConversationTopics { get; set; }
}
