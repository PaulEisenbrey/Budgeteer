using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Database.BaseClasses.Interfaces;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.BaseClasses;

public class QaLibCrud : ContextGenerator, IQaLibCrud, IContextGenerator
{
    public QaLibCrud(ILogManager logMgr) : base(logMgr)
    {
    }

    public virtual async Task<ReturnValue<int>> CreateAsync<T, C>(T entity, C? context = null)
        where T : class, new()
        where C : DbContext, new()
    {
        try
        {
            EvaluateArgument.Execute(entity, fn => null != entity, $"Creation Failure: {typeof(T)} cannot be null");

            var ctx = this.EnsureContext(context);

            await ctx.Set<T>().AddAsync(entity).ConfigureAwait(false);
            var numChangesSaved = await ctx.SaveChangesAsync().ConfigureAwait(false);

            return ReturnValue<int>.From(numChangesSaved);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<int>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<int>.FromError(ex);
        }
    }

    public virtual async Task<ReturnValue<int>> CreateManyAsync<T, C>(IEnumerable<T> entities, C? context = null)
        where T : class, new()
        where C : DbContext, new()
    {
        try
        {
            EvaluateArgument.Execute(entities, fn => 0 < entities.Count(), $"Creation Failure: List of {typeof(T)} cannot be empty");

            var ctx = this.EnsureContext(context);

            await ctx.Set<T>().AddRangeAsync(entities).ConfigureAwait(false);
            var numChangesSaved = await ctx.SaveChangesAsync().ConfigureAwait(false);

            return ReturnValue<int>.From(numChangesSaved);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<int>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<int>.FromError(ex);
        }
    }

    public virtual async Task<ReturnValue<T>> RetrieveByIdAsync<T, IdType, C>(IdType id, C? context = null)
        where T : class, new()
        where IdType : IConvertible
        where C : DbContext, new()
    {
        try
        {
            var entity = await this.EnsureContext(context).FindAsync<T>(id).ConfigureAwait(false);

            return null == entity
                ? ReturnValue<T>.FromError($"Unable to find {typeof(T)} record by id {id}")
                : ReturnValue<T>.From(entity);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<T>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<T>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<T>>> RetrieveManyByQueryAsync<T, C>(Expression<Func<T, bool>> predicate, C? context = null)
        where C : DbContext, new()
        where T : class, new()
    {
        try
        {
            var entity = await this.EnsureContext(context).Set<T>().Where(predicate).ToListAsync().ConfigureAwait(false);

            return null == entity
                ? ReturnValue<List<T>>.FromError($"Unable to find {typeof(T)} record")
                : ReturnValue<List<T>>.From(entity);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<T>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<T>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<T>> RetrieveByQueryAsync<T, C>(Expression<Func<T, bool>> predicate, C? context = null)
        where C : DbContext, new()
        where T : class, new()
    {
        try
        {
            var entity = await this.EnsureContext(context).Set<T>().FirstOrDefaultAsync(predicate).ConfigureAwait(false);

            return null == entity
                ? ReturnValue<T>.FromError($"Unable to find {typeof(T)} record")
                : ReturnValue<T>.From(entity);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<T>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<T>.FromError(ex);
        }
    }

    public virtual async Task<ReturnValue<List<T>>> RetrieveManyByIdsAsync<T, IdType, C>(IEnumerable<IdType> ids, C? context = null)
        where T : class, new()
        where IdType : IConvertible
        where C : DbContext, new()
    {
        try
        {
            var entities = await this.EnsureContext(context).FindAsync<IEnumerable<T>>(ids).ConfigureAwait(false);

            _ = entities ?? throw new Exception($"Received NULL response from query into {typeof(T)}");

            return 0 == entities.Count()
                    ? ReturnValue<List<T>>.FromError($"Unable to find {typeof(T)} records")
                    : ReturnValue<List<T>>.From(entities.ToList());
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<T>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<T>>.FromError(ex);
        }
    }

    public virtual async Task<ReturnValue<List<T>>> RetrieveAllAsync<T, C>(C? context = null)
        where T : class, new()
        where C : DbContext, new()
    {
        try
        {
            var entities = await this.EnsureContext(context).Set<T>().ToListAsync().ConfigureAwait(false);

            return 0 == entities.Count()
                ? ReturnValue<List<T>>.FromError($"Unable to find {typeof(T)} records")
                : ReturnValue<List<T>>.From(entities);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<T>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<T>>.FromError(ex);
        }
    }

    public virtual ReturnValue<List<T>> RetrieveAll<T, C>(C? context = null)
        where T : class, new()
        where C : DbContext, new()
    {
        try
        {
            var entities = this.EnsureContext(context).Set<T>().ToList();

            return 0 == entities.Count()
                ? ReturnValue<List<T>>.FromError($"Unable to find {typeof(T)} records")
                : ReturnValue<List<T>>.From(entities);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<T>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<T>>.FromError(ex);
        }
    }

    public virtual async Task<ReturnValue<List<T>>> RetrieveSubSetAsync<T, C>(int skip, int take, C? context = null)
        where T : class, new()
        where C : DbContext, new()
    {
        EvaluateArgument.Execute(skip, fn => 0 <= skip, $"Skip Value {skip} must be zero or greater");
        EvaluateArgument.Execute(take, fn => 0 <= take, $"Take Value {take} must be zero or greater");
        try
        {
            var entities = await this.EnsureContext(context).Set<T>().Skip(skip).Take(take).ToListAsync().ConfigureAwait(false);

            return 0 == entities.Count()
                ? ReturnValue<List<T>>.FromError($"Unable to find {typeof(T)} records")
                : ReturnValue<List<T>>.From(entities);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<T>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<T>>.FromError(ex);
        }
    }

    public virtual async Task<ReturnValue<int>> UpdateAsync<T, C>(T entity, C? context = null) where T : class, new() where C : DbContext, new()
    {
        try
        {
            EvaluateArgument.Execute(entity, fn => null != entity, $"Update Failure: {typeof(T)} cannot be null");

            var ctx = this.EnsureContext(context);

            var entityPrime = ctx.Set<T>().Update(entity);
            if (null == entityPrime)
            {
                throw new Exception($"Update Failure for {typeof(T)}");
            }

            var numChangesSaved = await ctx.SaveChangesAsync().ConfigureAwait(false);

            return ReturnValue<int>.From(numChangesSaved);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<int>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<int>.FromError(ex);
        }
    }

    public virtual async Task<ReturnValue<int>> UpdateManyAsync<T, C>(IEnumerable<T> entities, C? context = null) where T : class, new() where C : DbContext, new()
    {
        try
        {
            EvaluateArgument.Execute(entities, fn => 0 > entities.Count(), $"Update Failure: List of {typeof(T)} cannot be empty");

            var ctx = this.EnsureContext(context);

            ctx.Set<T>().UpdateRange(entities);
            var numChangesSaved = await ctx.SaveChangesAsync().ConfigureAwait(false);

            return ReturnValue<int>.From(numChangesSaved);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<int>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<int>.FromError(ex);
        }
    }

    public virtual async Task<ReturnValue<int>> DeleteAsync<T, C>(T entity, C? context = null) where T : class, new() where C : DbContext, new()
    {
        try
        {
            EvaluateArgument.Execute(entity, fn => null != entity, $"Deletion Failure: {typeof(T)} cannot be null");

            var ctx = this.EnsureContext(context);

            var entityPrime = ctx.Set<T>().Remove(entity);
            if (null == entityPrime)
            {
                throw new Exception($"Update Failure for {typeof(T)}");
            }

            var numChangesSaved = await ctx.SaveChangesAsync().ConfigureAwait(false);

            return ReturnValue<int>.From(numChangesSaved);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<int>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<int>.FromError(ex);
        }
    }
}