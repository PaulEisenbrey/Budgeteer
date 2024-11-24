namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientPhoneNumberPreference
{
    public Guid Id { get; set; }
    public Guid RecipientPhoneNumberId { get; set; }
    public Guid PreferenceId { get; set; }

    public virtual CommServicesRecipientPreference? Preference { get; set; }
    public virtual CommServicesRecipientRecipientPhoneNumber? RecipientPhoneNumber { get; set; }
}
