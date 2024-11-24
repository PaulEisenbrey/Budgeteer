namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboEnrollmentRequestAttribution
{
    public Guid EnrollmentRequestId { get; set; }
    public Guid AttributionTypeId { get; set; }
    public string? Data { get; set; }

    public virtual QuoteDboAttributionType? AttributionType { get; set; }
    public virtual QuoteDboEnrollmentRequest? EnrollmentRequest { get; set; }
}
