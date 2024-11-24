using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.TestData.PricingFactor;
using Utilities.Constants.Enum;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface ITestDataPricingFactorCrud : IQaLibCrud
{
    Task<ReturnValue<List<TestDataPricingFactorAffinityGroup>>> RetrieveAffinityGroupFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorAgeFactor>>> RetrieveAgeFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorBreedFactor>>> RetrieveBreedFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorCoInsurance>>> RetrieveCoInsuranceFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorDeductibleFactor>>> RetrieveDeductibleFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorEmployeeBenefitFactor>>> RetrieveEmployeeBenefitFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorExamFeeFactor>>> RetrieveExamFeeFactors(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorExpenseRateFactor>>> RetrieveExpenseRateFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorFoodFactor>>> RetrieveFoodFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorGenderFactor>>> RetrieveGenderFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorGeo>>> RetrieveGeoFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorHospital>>> RetrieveHospitalFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorLimitedCoverage>>> RetrieveLimitedCoverageFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<TestDataPricingFactorRateCardState>> RetrieveMostRecentLegacyRateCardStateAbbrAsync(TrupStates state, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<TestDataPricingFactorRateCardState>> RetrieveMostRecentNonLegacyRateCardStateAbbrAsync(TrupStates state, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorRiderA>>> RetrieveRiderAFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorRiderB>>> RetrieveRiderBFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorSpayNeuter>>> RetrieveSpayNeuterFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorStateHeader>>> RetrieveStateHeaderFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorStateTrend>>> RetrieveStateTrendFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorVcaWellnessDiscount>>> RetrieveVcaWellnessFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorWaitingPeriod>>> RetrieveWaitingPeriodFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorWebLinkPartner>>> RetrieveWebLinkFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
    Task<ReturnValue<List<TestDataPricingFactorWorkingGroup>>> RetrieveWorkingGroupFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null);
}