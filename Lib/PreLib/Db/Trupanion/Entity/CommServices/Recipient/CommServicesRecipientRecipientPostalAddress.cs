namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientPostalAddress
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? Name { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? PostalCode { get; set; }
    public string? CountryCode { get; set; }
    public Guid RecipientId { get; set; }
    public int AddressClassificationId { get; set; }

    public virtual CommServicesRecipientAddressClassification? AddressClassification { get; set; }
    public virtual CommServicesRecipientRecipient? Recipient { get; set; }
    public virtual List<CommServicesRecipientRecipientPostalAddressDeliveryMedium> RecipientPostalAddressDeliveryMedia { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPostalAddressPreference> RecipientPostalAddressPreferences { get; set; } = new();
}
