using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Utilities.ReturnType;

namespace Database.BaseClasses.Interfaces;

public interface IDatabaseCrud
{
    Task<ReturnValue<int>> CreateAsync<T, C>(T entity, C? context) where T : class, new() where C : class, new();
    Task<ReturnValue<int>> CreateManyAsync<T, C>(IEnumerable<T> entities, C? context)
            where T : class, new()
            where C : class, new();
    Task<ReturnValue<List<T>>> RetrieveManyByQueryAsync<T, C>(Expression<Func<T, bool>> predicate, C? context) where C : class, new() where T : class, new();
    Task<ReturnValue<T>> RetrieveByQueryAsync<T, C>(Expression<Func<T, bool>> predicate, C? context) where C : class, new() where T : class, new();
    Task<ReturnValue<T>> RetrieveByIdAsync<T, IdType, C>(IdType id, C? context) where C : class, new() where IdType : IConvertible where T : class, new();
    Task<ReturnValue<List<T>>> RetrieveManyByIdsAsync<T, IdType, C>(IEnumerable<IdType> ids, C? context) where C : class, new() where IdType : IConvertible where T : class, new();
    Task<ReturnValue<List<T>>> RetrieveAllAsync<T, C>(C? context) where C : class, new() where T : class, new();
    Task<ReturnValue<int>> UpdateAsync<T, C>(T entity, C? context) where T : class, new() where C : class, new();
    Task<ReturnValue<int>> UpdateManyAsync<T, C>(IEnumerable<T> entity, C? context) where T : class, new() where C : class, new();
    Task<ReturnValue<int>> DeleteAsync<T, C>(T entity, C? context) where T : class, new() where C : class, new();
    Task<ReturnValue<List<T>>> RetrieveSubSetAsync<T, C>(int skip, int take, C? context) where T : class, new() where C : class, new();
    ReturnValue<List<T>> RetrieveAll<T, C>(C? context) where T : class, new() where C : class, new();
}
