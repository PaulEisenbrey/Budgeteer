namespace Database.Trupanion.Entity.Workflow;

public class WFDboConversationAction
{
    public WFDboConversationAction()
    {
        ConversationActivities = new HashSet<WFDboConversationActivity>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public long? VersionId { get; set; }
    public string Description { get; set; } = "";

    public virtual ICollection<WFDboConversationActivity> ConversationActivities { get; set; }
}
