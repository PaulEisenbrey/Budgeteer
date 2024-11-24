namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientPreference
{
    public Guid Id { get; set; }
    public Guid RecipientId { get; set; }
    public Guid PreferenceId { get; set; }

    public virtual CommServicesRecipientPreference? Preference { get; set; }
    public virtual CommServicesRecipientRecipient? Recipient { get; set; }
}
