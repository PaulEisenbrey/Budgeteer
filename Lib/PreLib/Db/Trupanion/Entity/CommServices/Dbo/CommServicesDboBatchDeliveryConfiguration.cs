namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboBatchDeliveryConfiguration
{
    public CommServicesDboBatchDeliveryConfiguration()
    {
        BatchDeliveryContentConfigurations = new HashSet<CommServicesDboBatchDeliveryContentConfiguration>();
    }

    public int Id { get; set; }
    public int TaskInstanceBatchConfigurationId { get; set; }
    public string? DeliveryRecipientProjectionTypeName { get; set; }
    public Guid? ValidationTaskFlowUniqueId { get; set; }
    public string? SendAbandonedDeliveryMediumChangedService { get; set; }
    public string? ConditionalSendAbandonOnBouncebackService { get; set; }

    public virtual ICollection<CommServicesDboBatchDeliveryContentConfiguration> BatchDeliveryContentConfigurations { get; set; }
}
