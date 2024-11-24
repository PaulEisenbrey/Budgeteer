using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.TestData.PricingFactor;
using Utilities.ArgumentEvaluation;
using Utilities.Constants.Enum;
using Utilities.Extension;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.TestData.PricingFactor;

public class TestDataPricingFactorCrud : QaLibCrud, IQaLibCrud, ITestDataPricingFactorCrud
{
    public TestDataPricingFactorCrud(ILogManager logMgr) : base(logMgr)
    {

    }

    public async Task<ReturnValue<TestDataPricingFactorRateCardState>> RetrieveMostRecentLegacyRateCardStateAbbrAsync(TrupStates state, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(state, fn => state != TrupStates.Uninitialized && state != TrupStates.OutOfRange, "State request must be a valid string");

        var ctx = this.EnsureContext(context);

        try
        {
            var stateRec = await ctx.States.FirstOrDefaultAsync(st => st.IsLegacy ?? false && st.StateId == (int)state).ConfigureAwait(false);
            var rateCardState = await ctx.RateCardStates.Where(sh => null != stateRec && sh.StateId == stateRec.Id).OrderByDescending(rcs => rcs.Id).ToListAsync().ConfigureAwait(false);
            return 0 != rateCardState.Count()
            ? ReturnValue<TestDataPricingFactorRateCardState>.FromError($"Unable to find Legacy Rate Card State for {state.Description()}")
            : ReturnValue<TestDataPricingFactorRateCardState>.From(rateCardState.First());
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TestDataPricingFactorRateCardState>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TestDataPricingFactorRateCardState>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TestDataPricingFactorRateCardState>> RetrieveMostRecentNonLegacyRateCardStateAbbrAsync(TrupStates state, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(state, fn => state != TrupStates.Uninitialized && state != TrupStates.OutOfRange, "State request must be a valid string");

        var ctx = this.EnsureContext(context);
        try
        {
            var stateRec = await ctx.States.FirstOrDefaultAsync(st => !st.IsLegacy ?? false && st.StateId == (int)state).ConfigureAwait(false);
            var rateCardState = await ctx.RateCardStates.Where(sh => null != stateRec && sh.StateId == stateRec.Id).OrderByDescending(rcs => rcs.Id).ToListAsync().ConfigureAwait(false);
            return 0 != rateCardState.Count()
            ? ReturnValue<TestDataPricingFactorRateCardState>.FromError($"Unable to find Non-Legacy Rate Card State for {state.Description()}")
            : ReturnValue<TestDataPricingFactorRateCardState>.From(rateCardState.First());
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TestDataPricingFactorRateCardState>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TestDataPricingFactorRateCardState>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorAffinityGroup>>> RetrieveAffinityGroupFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var affinityGroups = await this.EnsureContext(context).AffinityGroups.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == affinityGroups.Count()
                ? ReturnValue<List<TestDataPricingFactorAffinityGroup>>.FromError($"Unable to find affinity groups for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorAffinityGroup>>.From(affinityGroups);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorAffinityGroup>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorAffinityGroup>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorAgeFactor>>> RetrieveAgeFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var ageFactors = await this.EnsureContext(context).AgeFactors.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == ageFactors.Count()
                ? ReturnValue<List<TestDataPricingFactorAgeFactor>>.FromError($"Unable to find age factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorAgeFactor>>.From(ageFactors);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorAgeFactor>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorAgeFactor>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorBreedFactor>>> RetrieveBreedFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var breedFactors = await this.EnsureContext(context).BreedFactors.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == breedFactors.Count()
                ? ReturnValue<List<TestDataPricingFactorBreedFactor>>.FromError($"Unable to find Breed factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorBreedFactor>>.From(breedFactors);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorBreedFactor>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorBreedFactor>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorCoInsurance>>> RetrieveCoInsuranceFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var coInsuranceFactors = await this.EnsureContext(context).CoInsurances.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == coInsuranceFactors.Count()
                ? ReturnValue<List<TestDataPricingFactorCoInsurance>>.FromError($"Unable to find CoInsurance factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorCoInsurance>>.From(coInsuranceFactors);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorCoInsurance>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorCoInsurance>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorDeductibleFactor>>> RetrieveDeductibleFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var deductibleFactors = await this.EnsureContext(context).DeductibleFactors.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == deductibleFactors.Count()
                ? ReturnValue<List<TestDataPricingFactorDeductibleFactor>>.FromError($"Unable to find Deductible factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorDeductibleFactor>>.From(deductibleFactors);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorDeductibleFactor>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorDeductibleFactor>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorEmployeeBenefitFactor>>> RetrieveEmployeeBenefitFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var benefitFactors = await this.EnsureContext(context).EmployeeBenefits.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == benefitFactors.Count()
                ? ReturnValue<List<TestDataPricingFactorEmployeeBenefitFactor>>.FromError($"Unable to find Employee Benefit factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorEmployeeBenefitFactor>>.From(benefitFactors);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorEmployeeBenefitFactor>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorEmployeeBenefitFactor>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorExamFeeFactor>>> RetrieveExamFeeFactors(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var examFeeFactors = await this.EnsureContext(context).ExamFees.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == examFeeFactors.Count()
                ? ReturnValue<List<TestDataPricingFactorExamFeeFactor>>.FromError($"Unable to find Employee Benefit factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorExamFeeFactor>>.From(examFeeFactors);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorExamFeeFactor>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorExamFeeFactor>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorExpenseRateFactor>>> RetrieveExpenseRateFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var expenseRateFactors = await this.EnsureContext(context).ExpenseRates.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == expenseRateFactors.Count()
                ? ReturnValue<List<TestDataPricingFactorExpenseRateFactor>>.FromError($"Unable to find Expense Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorExpenseRateFactor>>.From(expenseRateFactors);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorExpenseRateFactor>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorExpenseRateFactor>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorFoodFactor>>> RetrieveFoodFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var foodFactors = await this.EnsureContext(context).Foods.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == foodFactors.Count()
                ? ReturnValue<List<TestDataPricingFactorFoodFactor>>.FromError($"Unable to find Food Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorFoodFactor>>.From(foodFactors);
        }
        catch(Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorFoodFactor>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorFoodFactor>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorGenderFactor>>> RetrieveGenderFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var genderFactors = await this.EnsureContext(context).GenderFactors.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == genderFactors.Count()
                ? ReturnValue<List<TestDataPricingFactorGenderFactor>>.FromError($"Unable to find Gender factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorGenderFactor>>.From(genderFactors);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorGenderFactor>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorGenderFactor>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorGeo>>> RetrieveGeoFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var geoFactors = await this.EnsureContext(context).Geos.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == geoFactors.Count()
                ? ReturnValue<List<TestDataPricingFactorGeo>>.FromError($"Unable to find Geo (zip) Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorGeo>>.From(geoFactors);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorGeo>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorGeo>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorHospital>>> RetrieveHospitalFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var hospitalFactor = await this.EnsureContext(context).Hospitals.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == hospitalFactor.Count()
                ? ReturnValue<List<TestDataPricingFactorHospital>>.FromError($"Unable to find hospital Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorHospital>>.From(hospitalFactor);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorHospital>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorHospital>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorLimitedCoverage>>> RetrieveLimitedCoverageFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var limitedCoverageFactor = await this.EnsureContext(context).LimitedCoverages.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == limitedCoverageFactor.Count()
                ? ReturnValue<List<TestDataPricingFactorLimitedCoverage>>.FromError($"Unable to find limited coverage Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorLimitedCoverage>>.From(limitedCoverageFactor);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorLimitedCoverage>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorLimitedCoverage>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorRiderA>>> RetrieveRiderAFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var riderAFactor = await this.EnsureContext(context).RiderAs.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == riderAFactor.Count()
                ? ReturnValue<List<TestDataPricingFactorRiderA>>.FromError($"Unable to find Rider A Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorRiderA>>.From(riderAFactor);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorRiderA>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorRiderA>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorRiderB>>> RetrieveRiderBFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var riderBFactor = await this.EnsureContext(context).RiderBs.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == riderBFactor.Count()
                ? ReturnValue<List<TestDataPricingFactorRiderB>>.FromError($"Unable to find Rider B Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorRiderB>>.From(riderBFactor);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorRiderB>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorRiderB>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorSpayNeuter>>> RetrieveSpayNeuterFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var spayNeuterFactor = await this.EnsureContext(context).SpayNeuters.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == spayNeuterFactor.Count()
                ? ReturnValue<List<TestDataPricingFactorSpayNeuter>>.FromError($"Unable to find Spay/Neuter Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorSpayNeuter>>.From(spayNeuterFactor);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorSpayNeuter>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorSpayNeuter>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorStateHeader>>> RetrieveStateHeaderFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var stateHeaders = await this.EnsureContext(context).StateHeaders.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == stateHeaders.Count()
                ? ReturnValue<List<TestDataPricingFactorStateHeader>>.FromError($"Unable to find State Header Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorStateHeader>>.From(stateHeaders);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorStateHeader>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorStateHeader>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorStateTrend>>> RetrieveStateTrendFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var stateTrends = await this.EnsureContext(context).StateTrends.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == stateTrends.Count()
                ? ReturnValue<List<TestDataPricingFactorStateTrend>>.FromError($"Unable to find State Trend Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorStateTrend>>.From(stateTrends);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorStateTrend>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorStateTrend>>.FromError(ex);
        }
    }

    
    public async Task<ReturnValue<List<TestDataPricingFactorVcaWellnessDiscount>>> RetrieveVcaWellnessFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var vcaWellnesses = await this.EnsureContext(context).VcaWellnessDiscounts.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == vcaWellnesses.Count()
                ? ReturnValue<List<TestDataPricingFactorVcaWellnessDiscount>>.FromError($"Unable to find VCA Wellness Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorVcaWellnessDiscount>>.From(vcaWellnesses);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorVcaWellnessDiscount>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorVcaWellnessDiscount>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorWaitingPeriod>>> RetrieveWaitingPeriodFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var waitingPeriods = await this.EnsureContext(context).WaitingPeriods.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == waitingPeriods.Count()
                ? ReturnValue<List<TestDataPricingFactorWaitingPeriod>>.FromError($"Unable to find Waiting Periods Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorWaitingPeriod>>.From(waitingPeriods);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorWaitingPeriod>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorWaitingPeriod>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorWebLinkPartner>>> RetrieveWebLinkFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var webLinks = await this.EnsureContext(context).WebLinkPartners.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == webLinks.Count()
                ? ReturnValue<List<TestDataPricingFactorWebLinkPartner>>.FromError($"Unable to find Web Link Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorWebLinkPartner>>.From(webLinks);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorWebLinkPartner>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorWebLinkPartner>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TestDataPricingFactorWorkingGroup>>> RetrieveWorkingGroupFactorsAsync(int rateCardStateId, TestDataPricingFactorContext? context = null)
    {
        EvaluateArgument.Execute(rateCardStateId, fn => rateCardStateId > 0, "Rate Card State Id must be a positive non-zero value");

        var workingGroups = await this.EnsureContext(context).WorkingGroups.Where(ag => ag.RateCardStateId == rateCardStateId).ToListAsync().ConfigureAwait(false);

        try
        {
            return 0 == workingGroups.Count()
                ? ReturnValue<List<TestDataPricingFactorWorkingGroup>>.FromError($"Unable to find Working Pet Rate factors for rate card state id {rateCardStateId}")
                : ReturnValue<List<TestDataPricingFactorWorkingGroup>>.From(workingGroups);
        }
        catch (Microsoft.Data.SqlClient.SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TestDataPricingFactorWorkingGroup>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TestDataPricingFactorWorkingGroup>>.FromError(ex);
        }
    }
}
