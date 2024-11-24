namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboCharity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal DefaultDonation { get; set; }
    public string? Url { get; set; }
    public string? LogoName { get; set; }
    public bool Active { get; set; }
    public int IntId { get; set; }
    public int CountryId { get; set; }
}
