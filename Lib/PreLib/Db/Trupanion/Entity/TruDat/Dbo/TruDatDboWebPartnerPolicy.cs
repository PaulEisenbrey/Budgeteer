namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWebPartnerPolicy
{
    public int Id { get; set; }
    public int WebPartnerId { get; set; }
    public int PolicyId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}
