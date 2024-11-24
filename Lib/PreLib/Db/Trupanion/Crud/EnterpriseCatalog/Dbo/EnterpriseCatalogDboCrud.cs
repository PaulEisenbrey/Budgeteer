using System.Linq.Expressions;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.EnterpriseCatalog.Dbo;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboCrud : QaLibCrud, IQaLibCrud, IEnterpriseCatalogDboCrud
{
    public EnterpriseCatalogDboCrud(ILogManager logMgr) : base(logMgr)
    {
        
    }
    public async Task<ReturnValue<EnterpriseCatalogDboEnterpriseError>>RetrieveErrorByUniqueCodeAsync(string uniqueCode, EnterpriseCatalogDboContext? context = null)
    {
        try
        {
            var errorText = await this.EnsureContext(context).EnterpriseErrors.FirstOrDefaultAsync(errCode => errCode.UniqueCode == uniqueCode).ConfigureAwait(false);
            return (null == errorText)
                ? ReturnValue<EnterpriseCatalogDboEnterpriseError>.FromError($"No error found for code {uniqueCode}")
                : ReturnValue<EnterpriseCatalogDboEnterpriseError>.From(errorText);
        }
        catch (Exception ex)
        {
            return ReturnValue<EnterpriseCatalogDboEnterpriseError>.FromError(ex);

        }
    }

    public ReturnValue<EnterpriseCatalogDboEnterpriseEntity> RetrieveEnterpriseEntityById(int id, EnterpriseCatalogDboContext? context = null)
    {
        try
        {
            var entity = this.EnsureContext(context).EnterpriseEntities.FirstOrDefault(ee => ee.Id == id);
            EvaluateArgument.Execute(entity, fn => null != entity, $"No entity found for id {id}");

            return ReturnValue<EnterpriseCatalogDboEnterpriseEntity>.From(entity!);
        }
        catch (SqlException sqex)
        {
            return ReturnValue<EnterpriseCatalogDboEnterpriseEntity>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<EnterpriseCatalogDboEnterpriseEntity>.FromError(ex);
        }
    }

    public ReturnValue<EnterpriseCatalogDboEnterpriseEntity> RetrieveEnterpriseEntityByType(string eType, EnterpriseCatalogDboContext? context = null)
    {
        try
        {
            Expression<Func<EnterpriseCatalogDboEnterpriseEntity, bool>> predicate = enterpriseEnt => enterpriseEnt.EntityType!.ToLower() == eType.ToLower();
            var entity = this.EnsureContext(context).EnterpriseEntities.FirstOrDefault(predicate);
            EvaluateArgument.Execute(entity, fn => null != entity, $"No entity found for type {eType}");

            return ReturnValue<EnterpriseCatalogDboEnterpriseEntity>.From(entity!);
        }
        catch (SqlException sqex)
        {
            return ReturnValue<EnterpriseCatalogDboEnterpriseEntity>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<EnterpriseCatalogDboEnterpriseEntity>.FromError(ex);
        }
    }

    public ReturnValue<EnterpriseCatalogDboEnterpriseEvent> RetrieveEnterpriseEventByUniqueId(Guid id, EnterpriseCatalogDboContext? context = null)
    {
        try
        {
            Expression<Func<EnterpriseCatalogDboEnterpriseEvent, bool>> predicate = enterpriseEvent => enterpriseEvent.UniqueId == id;
            var entity = this.EnsureContext(context).EnterpriseEvents.FirstOrDefault(predicate);
            EvaluateArgument.Execute(entity, fn => null != entity, $"No entity found for type {id}");

            return ReturnValue<EnterpriseCatalogDboEnterpriseEvent>.From(entity!);
        }
        catch (SqlException sqex)
        {
            return ReturnValue<EnterpriseCatalogDboEnterpriseEvent>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            return ReturnValue<EnterpriseCatalogDboEnterpriseEvent>.FromError(ex);
        }
    }
}
