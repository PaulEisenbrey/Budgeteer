namespace Database.Trupanion.Entity.Clu.CLUDbo;

public  class CLUDboDeletedLocation
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsEligible { get; set; }
    public int? ParentId { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
}
