namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboQuote
{
    public int Id { get; set; }
    public int? ParentQuoteId { get; set; }
    public int? CreationReasonId { get; set; }
    public string? PostalCode { get; set; }
    public string? CampaignCode { get; set; }
    public string? CampaignCodeReferenceNumber { get; set; }
    public int? CampaignInstanceId { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public int? PlatformId { get; set; }
    public int? PriceEngineVersionId { get; set; }
    public int? CountryId { get; set; }
    public int? LeadId { get; set; }
    public DateTime? EffectiveDate { get; set; }
    public Guid? ReferenceNumber { get; set; }
    public string? Tag { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? EmailAddress { get; set; }
    public string? Source { get; set; }
    public Guid? AffiliateId { get; set; }
    public string? WebSalesReferenceNumber { get; set; }
    public string? OwnerFirstName { get; set; }
    public string? OwnerLastName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }
    public string? PrimaryPhoneNumber { get; set; }
    public bool PrimaryPhoneNumberIsCell { get; set; }
    public string? AlternatePhoneNumber { get; set; }
    public bool AlternatePhoneNumberIsCell { get; set; }
    public Guid? WebSalesId { get; set; }
    public int? ClinicId { get; set; }
    public Guid? PlanId { get; set; }
    public Guid? ProductId { get; set; }
    public Guid? PriceEngineVersionUniqueId { get; set; }
    public bool? IsSmsOptedIn { get; set; }
    public string? Partner { get; set; }
    public Guid? AssociateUniqueId { get; set; }
    public string? QuoteUrl { get; set; }
    public string? ShortenedQuoteUrl { get; set; }

    public virtual QuoteDboQuote? ParentQuote { get; set; }
    public virtual List<QuoteDboQuote> InverseParentQuote { get; set; } = new();
    public virtual List<QuoteDboQuotePet> QuotePets { get; set; } = new();
}
