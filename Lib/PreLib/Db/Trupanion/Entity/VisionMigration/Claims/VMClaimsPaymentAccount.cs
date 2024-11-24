namespace Database.TestData.VisionMigrationClaims;

public class VMClaimsPaymentAccount
{
    public int OwnerId { get; set; }
    public Guid AccountId { get; set; }
    public string? RoutingNumber { get; set; }
    public string? NameOnAccount { get; set; }
    public string? AccountNumber { get; set; }
    public string? AccountType { get; set; }
    public string? BankName { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int ChangeUserId { get; set; }
    public DateTimeOffset? ModifiedOn { get; set; }
}
