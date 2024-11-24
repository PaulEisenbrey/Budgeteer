namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientPhoneNumberDeliveryMedium
{
    public Guid Id { get; set; }
    public Guid RecipientPhoneNumberId { get; set; }
    public int DeliveryMediumId { get; set; }

    public virtual CommServicesRecipientRecipientPhoneNumber? RecipientPhoneNumber { get; set; }
}
