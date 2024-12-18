using Database.Context;
using Database.Models;
using Utilities.ReturnType;

namespace Database.Serializers
{
    public interface IInstitutionsAccess
    {
        Task<ReturnValue<int>> CreateNewInstitution(Institution newInst, BudgeteerContext? context = null);
        Task<ReturnValue<Institution>> LoadInstitutionTreeAsync(int institutionId, BudgeteerContext? context = null);
    }
}