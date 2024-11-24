namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboDeliveryAddress
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }

    public virtual List<CommServicesDboDeliveryAdminRecipientContentConfiguration> DeliveryAdminRecipientContentConfigurations { get; set; } = new();
    public virtual List<CommServicesDboDeliverySenderContentConfiguration> DeliverySenderContentConfigurations { get; set; } = new();
}
