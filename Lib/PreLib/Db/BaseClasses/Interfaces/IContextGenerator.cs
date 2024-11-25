using Database.Context;
using Utilities.ReturnType;

namespace Database.BaseClasses.Interfaces;

public interface IContextGenerator
{
    BudgeteerContext GenerateBudgeteerContext();
    ReturnValue<List<T>> GenerateReturnValue<T>(ReturnValue<List<T>> resultToTest, string nullResults, string noResults) where T : class, new();
    ReturnValue<T> GenerateReturnValue<T>(ReturnValue<T> resultToTest, string nullResults) where T : class, new();
}
