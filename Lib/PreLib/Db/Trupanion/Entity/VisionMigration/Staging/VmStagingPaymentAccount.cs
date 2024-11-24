namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingPaymentAccount
{
    public int? Id { get; set; }
    public string? AccountName { get; set; }
    public string? SortCode { get; set; }
    public string? AccountNumber { get; set; }
    public string? BankName { get; set; }
    public string? Payee { get; set; }
    public int PaymentMethod { get; set; }
    public int? CustomerId { get; set; }
    public int? VetId { get; set; }
    public int OriginalClaimId { get; set; }
    public int ExtRef { get; set; }
    public Guid? Ref { get; set; }
    public DateTimeOffset? ModifiedDateTime { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public bool? IsActive { get; set; }
    public int OwnerId { get; set; }
    public Guid BatchId { get; set; }
}
