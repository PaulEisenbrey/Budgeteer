namespace Database.Trupanion.Entity.Clu.CLUDbo;

public  class CLUDboConceptHistory
{
    public int Id { get; set; }
    public int ConceptId { get; set; }
    public int ConceptTypeId { get; set; }
    public int? CustomerPreferredConditionId { get; set; }
    public int? VetPreferredConditionId { get; set; }
    public long? ExternalId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime EffectiveTo { get; set; }
}
