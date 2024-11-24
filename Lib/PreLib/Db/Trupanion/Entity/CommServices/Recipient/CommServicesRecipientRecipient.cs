namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipient
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int RecipientEntityTypeId { get; set; }
    public string? RecipientEntityId { get; set; }
    public string? LanguageCode { get; set; }

    public virtual CommServicesRecipientRecipientType? RecipientEntityType { get; set; }
    public virtual List<CommServicesRecipientRecipientBrand> RecipientBrands { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientEmailAddress> RecipientEmailAddresses { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPhoneNumber> RecipientPhoneNumbers { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPostalAddress> RecipientPostalAddresses { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPreference> RecipientPreferences { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPushNotificationAddress> RecipientPushNotificationAddresses { get; set; } = new();
}
