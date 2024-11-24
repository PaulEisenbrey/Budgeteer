namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseApplicationStatisticConfig
{
    public int Id { get; set; }
    public int EnterpriseApplicationId { get; set; }
    public string? StatisticSource { get; set; }
    public bool Disabled { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseApplication? EnterpriseApplication { get; set; }
}
