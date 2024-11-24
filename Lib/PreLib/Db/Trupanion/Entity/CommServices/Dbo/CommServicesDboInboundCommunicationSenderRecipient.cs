namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboInboundCommunicationSenderRecipient
{
    public int Id { get; set; }
    public int InboundCommunicationId { get; set; }
    public Guid RecipientId { get; set; }
}
