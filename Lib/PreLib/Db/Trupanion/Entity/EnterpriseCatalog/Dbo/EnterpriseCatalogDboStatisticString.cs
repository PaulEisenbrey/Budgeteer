namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboStatisticString
{
    public int Id { get; set; }
    public int EnterpriseApplicationId { get; set; }
    public string? StatisticSource { get; set; }
    public string? String { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }
}
