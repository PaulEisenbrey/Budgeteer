namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientPreference
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int? RequiredDeliveryMediumId { get; set; }

    public virtual List<CommServicesRecipientRecipientEmailAddressPreference> RecipientEmailAddressPreferences { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPhoneNumberPreference> RecipientPhoneNumberPreferences { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPostalAddressPreference> RecipientPostalAddressPreferences { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPreference> RecipientPreferences { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPushNotificationAddressPreference> RecipientPushNotificationAddressPreferences { get; set; } = new();
}
