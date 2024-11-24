namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboQuoteSecondaryHospital
{
    public int Id { get; set; }
    public int QuotePetId { get; set; }
    public int? HospitalId { get; set; }
    public Guid? HospitalUniqueId { get; set; }
    public string? Name { get; set; }

    public virtual QuoteDboQuotePet? QuotePet { get; set; }
}
