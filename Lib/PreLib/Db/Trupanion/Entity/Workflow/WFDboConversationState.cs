namespace Database.Trupanion.Entity.Workflow;

public class WFDboConversationState
{
    public WFDboConversationState()
    {
        Conversations = new HashSet<WFDboConversation>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public long? VersionId { get; set; }

    public virtual ICollection<WFDboConversation> Conversations { get; set; }
}
