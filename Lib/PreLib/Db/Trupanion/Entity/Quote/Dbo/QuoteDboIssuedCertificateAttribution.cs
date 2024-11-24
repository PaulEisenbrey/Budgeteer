namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboIssuedCertificateAttribution
{
    public Guid Id { get; set; }
    public Guid IssuedCertificateId { get; set; }
    public Guid AttributionTypeId { get; set; }
    public string? Data { get; set; }

    public virtual QuoteDboAttributionType? AttributionType { get; set; }
    public virtual QuoteDboIssuedCertificate? IssuedCertificate { get; set; }
}
