namespace Database.Trupanion.Entity.Workflow;

public class WFDboActiveConversation
{
    public int ConversationId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string ConversationExchangeSummary { get; set; } = "";
    public string ConversationTopicIdList { get; set; } = "";
    public int ConversationStateId { get; set; }
    public int ConversationPriority { get; set; }
    public int TaskInstanceId { get; set; }
    public Guid? LockingUserId { get; set; }
    public DateTimeOffset? LockExpiration { get; set; }
    public Guid? HeartbeatBrokerHandle { get; set; }

    public virtual WFDboConversation? Conversation { get; set; }
}
