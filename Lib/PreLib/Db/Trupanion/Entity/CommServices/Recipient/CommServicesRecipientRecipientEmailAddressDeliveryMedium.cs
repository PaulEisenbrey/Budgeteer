namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientEmailAddressDeliveryMedium
{
    public Guid Id { get; set; }
    public Guid RecipientEmailAddressId { get; set; }
    public int DeliveryMediumId { get; set; }

    public virtual CommServicesRecipientRecipientEmailAddress? RecipientEmailAddress { get; set; }
}
