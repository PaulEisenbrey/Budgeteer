namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientAddressClassification
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<CommServicesRecipientRecipientEmailAddress> RecipientEmailAddresses { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPhoneNumber> RecipientPhoneNumbers { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPostalAddress> RecipientPostalAddresses { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPushNotificationAddress> RecipientPushNotificationAddresses { get; set; } = new();
}
