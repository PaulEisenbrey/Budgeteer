namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboPremiumCalculation
{
    public Guid Id { get; set; }
    public Guid PriceEngineId { get; set; }
    public decimal Value { get; set; }
    public int DurationMilliseconds { get; set; }
    public string? Log { get; set; }
    public DateTime CreatedOn { get; set; }
    public string? Characteristics { get; set; }
    public string? SelectedEndorsements { get; set; }
    public decimal DeductibleAmount { get; set; }
    public decimal CoinsurancePercent { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }
    public string? StateCode { get; set; }
    public string? PostalCode { get; set; }
    public string? Metadata { get; set; }
}
