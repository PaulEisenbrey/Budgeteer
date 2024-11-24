namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboAttributionType
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual List<QuoteDboEnrollmentRequestAttribution> EnrollmentRequestAttributions { get; set; } = new();
    public virtual List<QuoteDboIssuedCertificateAttribution> IssuedCertificateAttributions { get; set; } = new();
}
