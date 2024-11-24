namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientPostalAddressDeliveryMedium
{
    public Guid Id { get; set; }
    public Guid RecipientPostalAddressId { get; set; }
    public int DeliveryMediumId { get; set; }

    public virtual CommServicesRecipientRecipientPostalAddress? RecipientPostalAddress { get; set; }
}
