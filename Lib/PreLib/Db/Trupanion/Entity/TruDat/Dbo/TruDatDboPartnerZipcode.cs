namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPartnerZipcode
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public string? Zipcode { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboPartner? Partner { get; set; }
}
