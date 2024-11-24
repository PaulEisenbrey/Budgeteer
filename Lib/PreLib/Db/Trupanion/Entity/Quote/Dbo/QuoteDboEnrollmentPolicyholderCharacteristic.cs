namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboEnrollmentPolicyholderCharacteristic
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid EnrollmentRequestId { get; set; }
    public Guid PolicyholderCharacteristicId { get; set; }

    public virtual QuoteDboEnrollmentRequest? EnrollmentRequest { get; set; }
}
