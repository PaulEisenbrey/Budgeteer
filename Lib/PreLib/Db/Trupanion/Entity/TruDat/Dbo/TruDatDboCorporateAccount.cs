namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCorporateAccount
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int BillingDayOfMonth { get; set; }
    public int DefaultPaymentMethod { get; set; }
    public bool? AutomaticBilling { get; set; }
    public string? BillingContactEmail { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool? Active { get; set; }
    public Guid UniqueId { get; set; }

    public virtual List<TruDatDboCorporateAccountAddress> CorporateAccountAddresses { get; set; } = new();
    public virtual List<TruDatDboCorporateAccountCampaignInstance> CorporateAccountCampaignInstances { get; set; } = new();
    public virtual List<TruDatDboOwner> Owners { get; set; } = new();
}
