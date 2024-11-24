namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboExpiredOffer
{
    public Guid Id { get; set; }
    public Guid? HospitalUniqueId { get; set; }
    public string? PetName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public DateTime ExpirationDate { get; set; }
    public Guid AttributionTypeId { get; set; }
    public string? AttributionData { get; set; }
}
