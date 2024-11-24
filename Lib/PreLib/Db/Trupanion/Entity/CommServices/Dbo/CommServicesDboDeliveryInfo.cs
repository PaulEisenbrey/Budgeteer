namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboDeliveryInfo
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int DeliveryStrategyValidationStatusId { get; set; }
    public int PreferredDeliveryMedium { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public int PreferredContentType { get; set; }
    public string? PreferredLanguageCode { get; set; }
    public int DeliveryStatusId { get; set; }
    public bool EverMarkedAsDelivered { get; set; }
    public int? ContentRequestId { get; set; }
    public int? ValidationTaskInstanceId { get; set; }
    public bool WaitingForArchive { get; set; }
    public string? ArchivedDocumentId { get; set; }
    public int? EnterpriseEntityId { get; set; }
    public string? EntityId { get; set; }
    public string? DeliveryRecipientProjectionTypeName { get; set; }

    public virtual CommServicesDboDeliveryStatus? DeliveryStatus { get; set; }
    public virtual CommServicesDboDeliveryStrategyValidationStatus? DeliveryStrategyValidationStatus { get; set; }
    public virtual CommServicesDboDeliveryMedium? PreferredDeliveryMediumNavigation { get; set; }
    public virtual List<CommServicesDboCommunication> Communications { get; set; } = new();
    public virtual List<CommServicesDboDeliveryAttachment> DeliveryAttachments { get; set; } = new();
    public virtual List<CommServicesDboDeliveryContent> DeliveryContents { get; set; } = new();
    public virtual List<CommServicesDboDeliveryInfoSendAttempt> DeliveryInfoSendAttempts { get; set; } = new();
}
