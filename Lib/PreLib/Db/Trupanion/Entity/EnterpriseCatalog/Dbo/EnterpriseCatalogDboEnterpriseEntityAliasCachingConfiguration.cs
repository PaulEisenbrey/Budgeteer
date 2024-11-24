﻿namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseEntityAliasCachingConfiguration
{
    public int Id { get; set; }
    public int EnterpriseEntityAliasId { get; set; }
    public int CacheTypeId { get; set; }
    public int? EnterpriseApplicationId { get; set; }
    public string? ServiceConfiguration { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboCacheType? CacheType { get; set; }
    public virtual EnterpriseCatalogDboEnterpriseApplication? EnterpriseApplication { get; set; }
    public virtual EnterpriseCatalogDboEnterpriseEntityAlias? EnterpriseEntityAlias { get; set; }
}
