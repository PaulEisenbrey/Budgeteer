namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientPushNotificationAddressPreference
{
    public Guid Id { get; set; }
    public Guid RecipientPushNotificationAddressId { get; set; }
    public Guid PreferenceId { get; set; }

    public virtual CommServicesRecipientPreference? Preference { get; set; }
    public virtual CommServicesRecipientRecipientPushNotificationAddress? RecipientPushNotificationAddress { get; set; }
}
