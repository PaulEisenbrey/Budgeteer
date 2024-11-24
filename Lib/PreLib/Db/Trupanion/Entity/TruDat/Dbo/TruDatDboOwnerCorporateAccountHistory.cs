namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerCorporateAccountHistory
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public int CorporateAccountId { get; set; }
    public string? ActionType { get; set; }
    public DateTime ActionDate { get; set; }

    public virtual TruDatDboOwner? Owner { get; set; }
}
