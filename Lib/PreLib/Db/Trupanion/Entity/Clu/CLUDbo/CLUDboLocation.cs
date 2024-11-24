namespace Database.Trupanion.Entity.Clu.CLUDbo;

public  class CLUDboLocation
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsEligible { get; set; }
    public int? ParentId { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }

    public virtual CLUDboLocation? Parent { get; set; }
    public virtual List<CLUDboLocation> InverseParent { get; set; } = new();
}
