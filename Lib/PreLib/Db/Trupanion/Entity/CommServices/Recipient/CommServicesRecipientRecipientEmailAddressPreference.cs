namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientEmailAddressPreference
{
    public Guid Id { get; set; }
    public Guid RecipientEmailAddressId { get; set; }
    public Guid PreferenceId { get; set; }

    public virtual CommServicesRecipientPreference? Preference { get; set; }
    public virtual CommServicesRecipientRecipientEmailAddress? RecipientEmailAddress { get; set; }
}
