namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityBankAccount
{
    public int Id { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public string? BankName { get; set; }
    public string? TransitNumber { get; set; }
    public int? BankCode { get; set; }
    public string? AccountNumber { get; set; }
    public string? NameOnAccount { get; set; }
    public string? AccountType { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboEntity? EntityType { get; set; }
}
