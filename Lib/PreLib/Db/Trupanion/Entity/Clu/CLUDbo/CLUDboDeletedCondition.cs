namespace Database.Trupanion.Entity.Clu.CLUDbo;

public  class CLUDboDeletedCondition
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? ConceptId { get; set; }
    public bool IsEligible { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
}
