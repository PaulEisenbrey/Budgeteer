namespace Database.Trupanion.Entity.Clu.CLUDbo;

public  class CLUDboConditionHistory
{
    public int Id { get; set; }
    public int ConditionId { get; set; }
    public string? Name { get; set; }
    public int? ConceptId { get; set; }
    public bool IsEligible { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime EffectiveTo { get; set; }
}
