using Database.TestData.QuoteDbo;
using Database.Trupanion.Entity.Quote.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Quote.Dbo
{
    public interface IQuoteDboCrud
    {
        Task<ReturnValue<List<QuoteDboSelectedPolicyOption>>> RetrievePolicyOptionsByPetIdAsync(int petId, QuoteDboContext? context);
        Task<ReturnValue<List<QuoteDboSelectedWorkingPet>>> RetrieveWorkingPetByPetIdAsync(int petId, QuoteDboContext? context);
    }
}