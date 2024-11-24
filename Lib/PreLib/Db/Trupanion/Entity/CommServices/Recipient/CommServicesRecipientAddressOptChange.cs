namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientAddressOptChange
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid PreferenceId { get; set; }
    public bool OptedIn { get; set; }
    public int AddressTypeId { get; set; }
    public string? Address { get; set; }
    public string? ChangeSource { get; set; }
    public Guid? RecipientId { get; set; }
}
