using Database.Models;
using Utilities.ReturnType;

namespace Budgeteer.Scaffolding
{
    public interface IScaffold
    {
        ReturnValue<Institution> GetInstitution();
    }
}