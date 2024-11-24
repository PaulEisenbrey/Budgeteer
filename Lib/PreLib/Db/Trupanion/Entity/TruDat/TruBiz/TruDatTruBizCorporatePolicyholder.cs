namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizCorporatePolicyholder
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string EmailAddress { get; set; } = "";
    public int? CorporateAccountId { get; set; }
    public int EngineId { get; set; }
}
