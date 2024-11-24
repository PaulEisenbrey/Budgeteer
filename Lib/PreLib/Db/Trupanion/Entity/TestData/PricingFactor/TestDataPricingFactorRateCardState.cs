namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorRateCardState
{
    public int Id { get; set; }
    public int RateCardId { get; set; }
    public int StateId { get; set; }
    public DateTime EffectiveDate { get; set; }
    public bool IsActive { get; set; }
    public bool? IsLegacy { get; set; }

    public virtual TestDataPricingFactorRateCard? RateCard { get; set; }
    public virtual List<TestDataPricingFactorAffinityGroup> AffinityGroups { get; set; } = new();
    public virtual List<TestDataPricingFactorAgeFactor> AgeFactors { get; set; } = new();
    public virtual List<TestDataPricingFactorBreedFactor> BreedFactors { get; set; } = new();
    public virtual List<TestDataPricingFactorCoInsurance> CoInsurances { get; set; } = new();
    public virtual List<TestDataPricingFactorEmployeeBenefitFactor> EmployeeBenefits { get; set; } = new();
    public virtual List<TestDataPricingFactorExamFeeFactor> ExamFees { get; set; } = new();
    public virtual List<TestDataPricingFactorExpenseRateFactor> ExpenseRates { get; set; } = new();
    public virtual List<TestDataPricingFactorFoodFactor> Foods { get; set; } = new();
    public virtual List<TestDataPricingFactorGenderFactor> GenderFactors { get; set; } = new();
    public virtual List<TestDataPricingFactorGeo> Geos { get; set; } = new();
    public virtual List<TestDataPricingFactorHospital> Hospitals { get; set; } = new();
    public virtual List<TestDataPricingFactorLimitedCoverage> LimitedCoverages { get; set; } = new();
    public virtual List<TestDataPricingFactorRiderA> RiderAs { get; set; } = new();
    public virtual List<TestDataPricingFactorRiderB> RiderBs { get; set; } = new();
    public virtual List<TestDataPricingFactorSpayNeuter> SpayNeuters { get; set; } = new();
    public virtual List<TestDataPricingFactorStateHeader> StateHeaders { get; set; } = new();
    public virtual List<TestDataPricingFactorStateTrend> StateTrends { get; set; } = new();
    public virtual List<TestDataPricingFactorVcaWellnessDiscount> VcaWellnessDiscounts { get; set; } = new();
    public virtual List<TestDataPricingFactorWaitingPeriod> WaitingPeriods { get; set; } = new();
    public virtual List<TestDataPricingFactorWebLinkPartner> WebLinkPartners { get; set; } = new();
    public virtual List<TestDataPricingFactorWorkingGroup> WorkingGroups { get; set; } = new();
}
