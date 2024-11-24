namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizPolicyCoverageItem
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public string Name { get; set; } = "";
    public int EntityTypeId { get; set; }
    public bool TrackEffectiveDates { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime? EffectiveTo { get; set; }
}
