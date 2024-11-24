using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Utilities.ReturnType;

namespace Database.BaseClasses.Interfaces;

public interface IQaLibCrud
{
    Task<ReturnValue<int>> CreateAsync<T, C>(T entity, C? context = null) where T : class, new() where C : DbContext, new();
    Task<ReturnValue<int>> CreateManyAsync<T, C>(IEnumerable<T> entities, C? context = null)
            where T : class, new()
            where C : DbContext, new();
    Task<ReturnValue<List<T>>> RetrieveManyByQueryAsync<T, C>(Expression<Func<T, bool>> predicate, C? context = null) where C : DbContext, new() where T : class, new();
    Task<ReturnValue<T>> RetrieveByQueryAsync<T, C>(Expression<Func<T, bool>> predicate, C? context = null) where C : DbContext, new() where T : class, new();
    Task<ReturnValue<T>> RetrieveByIdAsync<T, IdType, C>(IdType id, C? context = null) where C : DbContext, new() where IdType : IConvertible where T : class, new();
    Task<ReturnValue<List<T>>> RetrieveManyByIdsAsync<T, IdType, C>(IEnumerable<IdType> ids, C? context = null) where C : DbContext, new() where IdType : IConvertible where T : class, new();
    Task<ReturnValue<List<T>>> RetrieveAllAsync<T, C>(C? context = null) where C : DbContext, new() where T : class, new();
    Task<ReturnValue<int>> UpdateAsync<T, C>(T entity, C? context = null) where T : class, new() where C : DbContext, new();
    Task<ReturnValue<int>> UpdateManyAsync<T, C>(IEnumerable<T> entity, C? context = null) where T : class, new() where C : DbContext, new();
    Task<ReturnValue<int>> DeleteAsync<T, C>(T entity, C? context = null) where T : class, new() where C : DbContext, new();
    Task<ReturnValue<List<T>>> RetrieveSubSetAsync<T, C>(int skip, int take, C? context = null) where T : class, new() where C : DbContext, new();
    ReturnValue<List<T>> RetrieveAll<T, C>(C? context = null) where T : class, new() where C : DbContext, new();
}
