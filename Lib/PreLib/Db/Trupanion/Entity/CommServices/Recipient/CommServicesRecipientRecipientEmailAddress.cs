namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientEmailAddress
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? Address { get; set; }
    public Guid RecipientId { get; set; }
    public int AddressClassificationId { get; set; }

    public virtual CommServicesRecipientAddressClassification? AddressClassification { get; set; }
    public virtual CommServicesRecipientRecipient? Recipient { get; set; }
    public virtual List<CommServicesRecipientRecipientEmailAddressDeliveryMedium> RecipientEmailAddressDeliveryMedia { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientEmailAddressPreference> RecipientEmailAddressPreferences { get; set; } = new();
}
