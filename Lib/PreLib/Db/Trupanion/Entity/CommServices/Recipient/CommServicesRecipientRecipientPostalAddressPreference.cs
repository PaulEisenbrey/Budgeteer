namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientPostalAddressPreference
{
    public Guid Id { get; set; }
    public Guid RecipientPostalAddressId { get; set; }
    public Guid PreferenceId { get; set; }

    public virtual CommServicesRecipientPreference? Preference { get; set; }
    public virtual CommServicesRecipientRecipientPostalAddress? RecipientPostalAddress { get; set; }
}
