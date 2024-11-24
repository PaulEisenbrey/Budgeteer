namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientPushNotificationAddressDeliveryMedium
{
    public Guid Id { get; set; }
    public Guid RecipientPushNotificationAddressId { get; set; }
    public int DeliveryMediumId { get; set; }

    public virtual CommServicesRecipientRecipientPushNotificationAddress? RecipientPushNotificationAddress { get; set; }
}
