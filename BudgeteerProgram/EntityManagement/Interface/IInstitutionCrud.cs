using Database.Context;
using Database.POCO.Budgeteer;
using Database.POCO.Images;

using Utilities.ReturnType;

namespace Budgeteer.EntityManagement.Interface;

public interface IInstitutionCrud 
{
    Task<ReturnValue<List<ActiveInstiutionNameAndId>>> GetActiveInstitutionHeaders(BudgeteerContext context);
    ReturnValue<Institution> NewInstitution();
    Task<ReturnValue<Institution>> RetrieveByIdAsync<T, IdType, C>(IdType id, C? context)
        where T : class
        where IdType : IConvertible
        where C : class, new();
    Task<ReturnValue<int>> SaveNewInstitution(Institution institution, BudgeteerContext context);
    Task<ReturnValue<int>> UpdateInstitution(Institution institution, BudgeteerContext context);
}