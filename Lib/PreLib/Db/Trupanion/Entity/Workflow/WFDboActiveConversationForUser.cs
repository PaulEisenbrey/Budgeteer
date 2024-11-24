namespace Database.Trupanion.Entity.Workflow;

public class WFDboActiveConversationForUser
{
    public int ConversationId { get; set; }
    public Guid UserId { get; set; }
    public int ConversationStateId { get; set; }
    public int TaskInstanceId { get; set; }
    public string ConversationExchangeSummary { get; set; } = "";
    public string ConversationTopicIdList { get; set; } = "";
    public int ConversationPriority { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
}
