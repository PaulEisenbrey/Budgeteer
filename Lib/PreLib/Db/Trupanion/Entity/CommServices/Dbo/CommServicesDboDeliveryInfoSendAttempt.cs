namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboDeliveryInfoSendAttempt
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int DeliveryInfoId { get; set; }
    public string? SentWithStrategy { get; set; }
    public string? StrategySpecificDeliveryId { get; set; }
    public string? StatusCode { get; set; }
    public string? Message { get; set; }
    public string? SerializedException { get; set; }
    public string? Address { get; set; }
    public string? Name { get; set; }

    public virtual CommServicesDboDeliveryInfo? DeliveryInfo { get; set; }
}
