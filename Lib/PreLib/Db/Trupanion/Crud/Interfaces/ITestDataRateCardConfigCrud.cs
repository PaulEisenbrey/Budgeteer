using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.TestData.RateCardConfig;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface ITestDataRateCardConfigCrud : IQaLibCrud
{
    Task<ReturnValue<List<TestDataRateCardConfigRateCardColumn>>> RetrieveAllRateCardColumnsAsync(TestDataRateCardConfigContext? context = null);
    Task<ReturnValue<List<TestDataRateCardConfigRateCardRowset>>> RetrieveAllRateCardRowSetsAsync(TestDataRateCardConfigContext? context = null);
    Task<ReturnValue<List<TestDataRateCardConfigRateCardSection>>> RetrieveAllRateCardSectionsAsync(TestDataRateCardConfigContext? context = null);
    Task<ReturnValue<List<TestDataRateCardConfigRateCardTab>>> RetrieveAllRateCardTabsAsync(TestDataRateCardConfigContext? context = null);
}