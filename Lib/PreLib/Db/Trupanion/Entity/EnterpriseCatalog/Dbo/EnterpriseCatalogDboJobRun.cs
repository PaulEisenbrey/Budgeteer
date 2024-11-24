namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboJobRun
{
    public int Id { get; set; }
    public int JobTypeId { get; set; }
    public DateTime StartedOn { get; set; }
    public DateTime? FinishedOn { get; set; }
    public string? MachineName { get; set; }
    public int EnterpriseApplicationId { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseApplication? EnterpriseApplication { get; set; }
}
