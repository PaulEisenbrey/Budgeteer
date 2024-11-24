namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboEnrollmentRequestType
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual List<QuoteDboEnrollmentRequest> EnrollmentRequests { get; set; } = new();
}
