namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboInboundCommunication
{
    public int Id { get; set; }
    public int DeliveryMediumId { get; set; }
    public string? FromAddress { get; set; }
    public string? ToAddress { get; set; }
    public string? Message { get; set; }
    public DateTime ReceivedOn { get; set; }
    public Guid? SenderRecipientId { get; set; }
}
