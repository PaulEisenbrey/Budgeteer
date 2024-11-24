namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseApplicationHostConfig
{
    public int Id { get; set; }
    public int EnterpriseApplicationId { get; set; }
    public int EnterpriseHostId { get; set; }
    public string? EndPointUrl { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseApplication? EnterpriseApplication { get; set; }
    public virtual EnterpriseCatalogDboEnterpriseHost? EnterpriseHost { get; set; }
}
