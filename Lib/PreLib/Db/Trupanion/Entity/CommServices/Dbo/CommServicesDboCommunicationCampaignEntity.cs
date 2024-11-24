namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboCommunicationCampaignEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid CommunicationId { get; set; }
    public Guid CampaignEntityId { get; set; }
    public string? EntityId { get; set; }

    public virtual CommServicesDboCommunication? Communication { get; set; }
}
