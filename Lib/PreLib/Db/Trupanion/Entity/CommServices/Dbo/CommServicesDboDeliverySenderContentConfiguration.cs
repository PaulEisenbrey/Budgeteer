namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboDeliverySenderContentConfiguration
{
    public int Id { get; set; }
    public int TemplateDefinitionId { get; set; }
    public int DeliveryAddressId { get; set; }

    public virtual CommServicesDboDeliveryAddress? DeliveryAddress { get; set; }
}
