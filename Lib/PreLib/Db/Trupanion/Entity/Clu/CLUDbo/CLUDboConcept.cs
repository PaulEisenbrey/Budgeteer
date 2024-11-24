namespace Database.Trupanion.Entity.Clu.CLUDbo;

public  class CLUDboConcept
{
    public int Id { get; set; }
    public int ConceptTypeId { get; set; }
    public int? CustomerPreferredConditionId { get; set; }
    public int? VetPreferredConditionId { get; set; }
    public long? ExternalId { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }

    public virtual CLUDboConceptType? ConceptType { get; set; }
    public virtual CLUDboCondition? CustomerPreferredCondition { get; set; }
    public virtual CLUDboCondition? VetPreferredCondition { get; set; }
    public virtual List<CLUDboCondition> Conditions { get; set; } = new();
}
