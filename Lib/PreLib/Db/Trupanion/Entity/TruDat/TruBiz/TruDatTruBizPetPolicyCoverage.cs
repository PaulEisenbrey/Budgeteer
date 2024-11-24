namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizPetPolicyCoverage
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public string RegulatoryName { get; set; } = "";
    public string PreferredName { get; set; } = "";
    public decimal Cost { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime? EffectiveTo { get; set; }
    public bool? IsDecPageVisible { get; set; }
    public int? PolicyVersionId { get; set; }
}
