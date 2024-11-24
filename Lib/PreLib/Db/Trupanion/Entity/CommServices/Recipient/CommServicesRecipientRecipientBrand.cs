namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientBrand
{
    public Guid Id { get; set; }
    public Guid RecipientId { get; set; }
    public Guid BrandId { get; set; }

    public virtual CommServicesRecipientRecipient? Recipient { get; set; }
}
