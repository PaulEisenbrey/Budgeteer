namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuoteQuotePetDatum
{
    public int Id { get; set; }
    public DateTime CoverStartDate { get; set; }
    public int? DetailsId { get; set; }
    public int QuoteId { get; set; }
    public string? TimeZoneCode { get; set; }
    public int CountryId { get; set; }
    public int CustomerId { get; set; }
}
