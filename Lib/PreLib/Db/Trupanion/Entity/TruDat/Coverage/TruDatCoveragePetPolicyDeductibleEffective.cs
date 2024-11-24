namespace Database.Trupanion.Entity.TruDat.Coverage;

public partial class TruDatCoveragePetPolicyDeductibleEffective
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime? EffectiveTo { get; set; }
    public decimal Deductible { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime? Updated { get; set; }
}
