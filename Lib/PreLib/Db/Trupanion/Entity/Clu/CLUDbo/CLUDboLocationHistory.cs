namespace Database.Trupanion.Entity.Clu.CLUDbo;

public  class CLUDboLocationHistory
{
    public int Id { get; set; }
    public int LocationId { get; set; }
    public string? Name { get; set; }
    public bool IsEligible { get; set; }
    public int? ParentId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime EffectiveTo { get; set; }
}
