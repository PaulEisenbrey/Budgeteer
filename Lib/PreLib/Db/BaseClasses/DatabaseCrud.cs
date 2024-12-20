using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Database.BaseClasses.Interfaces;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.BaseClasses;

public class DatabaseCrud : ContextGenerator, IDatabaseCrud, IContextGenerator
{
    public DatabaseCrud(ILogManager logMgr) : base(logMgr){}

    public virtual async Task<ReturnValue<int>> CreateAsync<T, C>(T entity, C? context)
        where T : class, new()
        where C : class, new()
    {
        try
        {
            EvaluateArgument.Execute(entity, fn => null != entity, $"Creation Failure: {typeof(T)} cannot be null");

            var ctx = this.EnsureContext(context);
            if (ctx is DbContext dbCtx)
            {
                await dbCtx.Set<T>().AddAsync(entity).ConfigureAwait(false);
                var numChangesSaved = await dbCtx.SaveChangesAsync().ConfigureAwait(false);

                return ReturnValue<int>.From(numChangesSaved);
            }

            throw new Exception($"Creation Failure: {typeof(C)} is not a valid DbContext");
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

    public virtual async Task<ReturnValue<int>> CreateManyAsync<T, C>(IEnumerable<T> entities, C? context)
        where T : class, new()
        where C : class, new()
    {
        try
        {
            EvaluateArgument.Execute(entities, fn => 0 < entities.Count(), $"Creation Failure: List of {typeof(T)} cannot be empty");

            var ctx = this.EnsureContext(context);
            if (ctx is DbContext dbCtx)
			{
				await dbCtx.Set<T>().AddRangeAsync(entities).ConfigureAwait(false);
				var numChangesSaved = await dbCtx.SaveChangesAsync().ConfigureAwait(false);
				return ReturnValue<int>.From(numChangesSaved);
			}

			throw new Exception($"Creation Failure: {typeof(C)} is not a valid DbContext");
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

    public virtual async Task<ReturnValue<T>> RetrieveByIdAsync<T, IdType, C>(IdType id, C? context)
        where T : class, new()
        where IdType : IConvertible
        where C : class, new()
    {
        try
        {
            var ctx = this.EnsureContext(context);
			if (ctx is DbContext dbCtx)
			{
				var entity = await dbCtx.FindAsync<T>(id).ConfigureAwait(false);
				return null == entity
					? ReturnValue<T>.FromError($"Unable to find {typeof(T)} record by id {id}")
					: ReturnValue<T>.From(entity);
			}

			throw new Exception($"Retrieve Failure: {typeof(C)} is not a valid DbContext");
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

    public async Task<ReturnValue<List<T>>> RetrieveManyByQueryAsync<T, C>(Expression<Func<T, bool>> predicate, C? context)
        where C : class, new()
        where T : class, new()
    {
        try
        {
            var ctx = this.EnsureContext(context);
			if (ctx is DbContext dbCtx)
			{
				var entity = await dbCtx.Set<T>().Where(predicate).ToListAsync().ConfigureAwait(false);
				return null == entity
					? ReturnValue<List<T>>.FromError($"Unable to find {typeof(T)} record")
					: ReturnValue<List<T>>.From(entity);
			}

			throw new Exception($"Retrieve Failure: {typeof(C)} is not a valid DbContext");
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

    public async Task<ReturnValue<T>> RetrieveByQueryAsync<T, C>(Expression<Func<T, bool>> predicate, C? context)
        where C : class, new()
        where T : class, new()
    {
        try
        {
			var ctx = this.EnsureContext(context);
			if (ctx is DbContext dbCtx)
			{
				var entity = await dbCtx.Set<T>().FirstOrDefaultAsync(predicate).ConfigureAwait(false);
				return null == entity
					? ReturnValue<T>.FromError($"Unable to find {typeof(T)} record")
					: ReturnValue<T>.From(entity);
			}

			throw new Exception($"Retrieve Failure: {typeof(C)} is not a valid DbContext");
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

    public virtual async Task<ReturnValue<List<T>>> RetrieveManyByIdsAsync<T, IdType, C>(IEnumerable<IdType> ids, C? context)
        where T : class, new()
        where IdType : IConvertible
        where C : class, new()
    {
        try
        {
            var ctx = this.EnsureContext(context);
            if (ctx is DbContext dbCtx)
			{
				var entities = await dbCtx.FindAsync<IEnumerable<T>>(ids).ConfigureAwait(false);
				return null == entities || 0 == entities.Count()
					? ReturnValue<List<T>>.FromError($"Unable to find {typeof(T)} records")
					: ReturnValue<List<T>>.From(entities.ToList());
			}

			throw new Exception($"Retrieve Failure: {typeof(C)} is not a valid DbContext");
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

    public virtual async Task<ReturnValue<List<T>>> RetrieveAllAsync<T, C>(C? context)
        where T : class, new()
        where C : class, new()
    {
        try
        {
			var ctx = this.EnsureContext(context);

			if (ctx is DbContext dbCtx)
			{
				var entities = await dbCtx.Set<T>().ToListAsync().ConfigureAwait(false);
				return 0 == entities.Count()
					? ReturnValue<List<T>>.FromError($"Unable to find {typeof(T)} records")
					: ReturnValue<List<T>>.From(entities);
			}

			throw new Exception($"Retrieve Failure: {typeof(C)} is not a valid DbContext");
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

    public virtual ReturnValue<List<T>> RetrieveAll<T, C>(C? context)
        where T : class, new()
        where C : class, new()
    {
        try
        {
            var ctx = this.EnsureContext(context);

            if (ctx is DbContext dbCtx)
			{
				var entities = dbCtx.Set<T>().ToList();
				return 0 == entities.Count()
					? ReturnValue<List<T>>.FromError($"Unable to find {typeof(T)} records")
					: ReturnValue<List<T>>.From(entities);
			}
			
            throw new($"Retrieve Failure: {typeof(C)} is not a valid DbContext");
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

    public virtual async Task<ReturnValue<List<T>>> RetrieveSubSetAsync<T, C>(int skip, int take, C? context)
        where T : class, new()
        where C : class, new()
    {
        EvaluateArgument.Execute(skip, fn => 0 <= skip, $"Skip Value {skip} must be zero or greater");
        EvaluateArgument.Execute(take, fn => 0 <= take, $"Take Value {take} must be zero or greater");

        try
        {
			var ctx = this.EnsureContext(context);

			if (ctx is DbContext dbCtx)
			{
				var entities = await dbCtx.Set<T>().Skip(skip).Take(take).ToListAsync().ConfigureAwait(false);
				return 0 == entities.Count()
					? ReturnValue<List<T>>.FromError($"Unable to find {typeof(T)} records")
					: ReturnValue<List<T>>.From(entities);
			}

			throw new($"Retrieve Failure: {typeof(C)} is not a valid DbContext");
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

    public virtual async Task<ReturnValue<int>> UpdateAsync<T, C>(T entity, C? context) where T : class, new() where C : class, new()
    {
        try
        {
            EvaluateArgument.Execute(entity, fn => null != entity, $"Update Failure: {typeof(T)} cannot be null");

            var ctx = this.EnsureContext(context);

            if (ctx is DbContext dbCtx)
            {
                var entityPrime = dbCtx.Set<T>().Update(entity);
                if (null == entityPrime)
                {
                    throw new Exception($"Update Failure for {typeof(T)}");
                }

                var numChangesSaved = await dbCtx.SaveChangesAsync().ConfigureAwait(false);

                return ReturnValue<int>.From(numChangesSaved);
            }

			throw new Exception($"Update Failure: {typeof(C)} is not a valid DbContext");
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

    public virtual async Task<ReturnValue<int>> UpdateManyAsync<T, C>(IEnumerable<T> entities, C? context) where T : class, new() where C : class, new()
    {
        try
        {
            EvaluateArgument.Execute(entities, fn => 0 > entities.Count(), $"Update Failure: List of {typeof(T)} cannot be empty");

            var ctx = this.EnsureContext(context);

            if (ctx is DbContext dbCtx)
			{
				dbCtx.Set<T>().UpdateRange(entities);
				var numChangesSaved = await dbCtx.SaveChangesAsync().ConfigureAwait(false);
				return ReturnValue<int>.From(numChangesSaved);
			}

            throw new Exception($"Retrieve Failure: {typeof(C)} is not a valid DbContext");
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

    public virtual async Task<ReturnValue<int>> DeleteAsync<T, C>(T entity, C? context) where T : class, new() where C : class, new()
    {
        try
        {
            EvaluateArgument.Execute(entity, fn => null != entity, $"Deletion Failure: {typeof(T)} cannot be null");

            var ctx = this.EnsureContext(context);

            if (ctx is DbContext dbCtx)
            {
                var entityPrime = dbCtx.Set<T>().Remove(entity);
                if (null == entityPrime)
                {
                    throw new Exception($"Update Failure for {typeof(T)}");
                }

                var numChangesSaved = await dbCtx.SaveChangesAsync().ConfigureAwait(false);

                return ReturnValue<int>.From(numChangesSaved);
            }

			throw new Exception($"Deletion Failure: {typeof(C)} is not a valid DbContext");
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