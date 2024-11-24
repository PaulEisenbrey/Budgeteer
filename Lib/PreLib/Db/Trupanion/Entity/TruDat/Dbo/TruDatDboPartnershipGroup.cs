namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPartnershipGroup
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<TruDatDboPreferredPartnership> PreferredPartnerships { get; set; } = new();
}
