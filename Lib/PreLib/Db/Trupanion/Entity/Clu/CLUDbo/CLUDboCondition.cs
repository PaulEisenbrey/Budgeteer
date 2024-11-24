namespace Database.Trupanion.Entity.Clu.CLUDbo;

public  class CLUDboCondition
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? ConceptId { get; set; }
    public bool IsEligible { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }

    public virtual CLUDboConcept? Concept { get; set; }
    public virtual List<CLUDboConcept> ConceptCustomerPreferredConditions { get; set; } = new();
    public virtual List<CLUDboConcept> ConceptVetPreferredConditions { get; set; } = new();
}
