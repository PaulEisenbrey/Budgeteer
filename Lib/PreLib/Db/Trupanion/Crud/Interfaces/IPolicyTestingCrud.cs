using Database.Trupanion.Context;
using Database.Trupanion.Entity.TestData.PolicyTesting;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces
{
    internal interface IPolicyTestingCrud
    {
        Task<ReturnValue<List<TestDataPolicyTestingState>>> RetrieveLegacyStates(TestDataPolicyTestingContext? context = null);
        Task<ReturnValue<List<TestDataPolicyTestingStateColumnOffset>>> RetrieveOffsets(TestDataPolicyTestingContext? context = null);
    }
}