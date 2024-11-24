using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.EnterpriseCatalog.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface IEnterpriseCatalogDboCrud : IQaLibCrud
{
    ReturnValue<EnterpriseCatalogDboEnterpriseEntity> RetrieveEnterpriseEntityById(int id, EnterpriseCatalogDboContext? context = null);
    ReturnValue<EnterpriseCatalogDboEnterpriseEntity> RetrieveEnterpriseEntityByType(string eType, EnterpriseCatalogDboContext? context = null);
    ReturnValue<EnterpriseCatalogDboEnterpriseEvent> RetrieveEnterpriseEventByUniqueId(Guid id, EnterpriseCatalogDboContext? context = null);
    Task<ReturnValue<EnterpriseCatalogDboEnterpriseError>> RetrieveErrorByUniqueCodeAsync(string uniqueCode, EnterpriseCatalogDboContext? context = null);
}