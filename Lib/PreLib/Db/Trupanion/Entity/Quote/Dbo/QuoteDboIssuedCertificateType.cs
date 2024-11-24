namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboIssuedCertificateType
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int IntId { get; set; }
    public string? Description { get; set; }

    public virtual List<QuoteDboIssuedCertificate> IssuedCertificates { get; set; } = new();
}
