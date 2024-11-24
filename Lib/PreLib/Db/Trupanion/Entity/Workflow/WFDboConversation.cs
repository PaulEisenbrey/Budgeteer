namespace Database.Trupanion.Entity.Workflow;

public class WFDboConversation
{
    public WFDboConversation()
    {
        ConversationActivities = new HashSet<WFDboConversationActivity>();
        ConversationExchanges = new HashSet<WFDboConversationExchange>();
        ConversationParticipants = new HashSet<WFDboConversationParticipant>();
        ConversationTopicLists = new HashSet<WFDboConversationTopicList>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public byte[]? ConcurrencyToken { get; set; }
    public int TaskInstanceId { get; set; }
    public int ConversationPriority { get; set; }
    public int ConversationStateId { get; set; }

    public virtual WFDboConversationState? ConversationState { get; set; }
    public virtual WFDboTaskInstance? TaskInstance { get; set; }
    public virtual WFDboActiveConversation? ActiveConversation { get; set; }
    public virtual ICollection<WFDboConversationActivity> ConversationActivities { get; set; }
    public virtual ICollection<WFDboConversationExchange> ConversationExchanges { get; set; }
    public virtual ICollection<WFDboConversationParticipant> ConversationParticipants { get; set; }
    public virtual ICollection<WFDboConversationTopicList> ConversationTopicLists { get; set; }
}
