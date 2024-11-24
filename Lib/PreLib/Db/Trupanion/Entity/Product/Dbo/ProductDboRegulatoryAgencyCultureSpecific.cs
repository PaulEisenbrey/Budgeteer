namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboRegulatoryAgencyCultureSpecific
{
    public long Id { get; set; }
    public Guid MasterId { get; set; }
    public string? LanguageCode { get; set; }
    public string? Name { get; set; }
    public bool? ProducerLicenseRequired { get; set; }
    public string? ShortName { get; set; }

    public virtual ProductDboRegulatoryAgency? Master { get; set; }
}
