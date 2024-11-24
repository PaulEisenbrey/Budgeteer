namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientPhoneNumber
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? CountryCode { get; set; }
    public string? NationalSignificantNumber { get; set; }
    public string? Extension { get; set; }
    public string? Country { get; set; }
    public string? InternationalNumber { get; set; }
    public Guid RecipientId { get; set; }
    public int AddressClassificationId { get; set; }

    public virtual CommServicesRecipientAddressClassification? AddressClassification { get; set; }
    public virtual CommServicesRecipientRecipient? Recipient { get; set; }
    public virtual List<CommServicesRecipientRecipientPhoneNumberDeliveryMedium> RecipientPhoneNumberDeliveryMedia { get; set; } = new();
    public virtual List<CommServicesRecipientRecipientPhoneNumberPreference> RecipientPhoneNumberPreferences { get; set; } = new();
}
