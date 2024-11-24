namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboStatusSummary
{
    public int StatusId { get; set; }
    public int? ParentId { get; set; }
    public string? StatusBreadCrumb { get; set; }
}
