namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEmergencyZipcode
{
    public string? Zipcode { get; set; }
    public int StateId { get; set; }
    public bool? Active { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboState? State { get; set; }
}
