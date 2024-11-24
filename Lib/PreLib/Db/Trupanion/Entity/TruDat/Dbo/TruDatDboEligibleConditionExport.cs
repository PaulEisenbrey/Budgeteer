namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEligibleConditionExport
{
    public int Id { get; set; }
    public int PetpolicyId { get; set; }
    public int PetId { get; set; }
    public string? LocationName { get; set; }
    public int? LocationId { get; set; }
    public string? ConditionName { get; set; }
    public int? ConditionId { get; set; }
    public bool? IsDuplicate { get; set; }
    public bool? IsExported { get; set; }
    public DateTime? ExportedDate { get; set; }
}
