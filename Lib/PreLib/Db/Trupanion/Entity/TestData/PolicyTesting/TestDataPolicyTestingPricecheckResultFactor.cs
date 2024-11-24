namespace Database.Trupanion.Entity.TestData.PolicyTesting;

public class TestDataPolicyTestingPricecheckResultFactor
{
    public int Id { get; set; }
    public int PricecheckResultId { get; set; }
    public string? FactorSource { get; set; }
    public double BaseRate { get; set; }
    public double TrendFactor { get; set; }
    public double GeoFactor { get; set; }
    public double HospitalFactor { get; set; }
    public double AgeFactor { get; set; }
    public double BreedFactor { get; set; }
    public double GenderFactor { get; set; }
    public double SpayFactor { get; set; }
    public double WorkingPetFactor { get; set; }
    public double TherapeuticFoodFactor { get; set; }
    public double ScienceDietFoodFactor { get; set; }
    public double ExamFeeFactor { get; set; }
    public double CoinsuranceFactor { get; set; }
    public double RecoveryFactor { get; set; }
    public double RiderBfactor { get; set; }
    public double ExpenseRate { get; set; }
    public double WebLinkPartnerFactor { get; set; }
    public double AffinityGroupFactor { get; set; }
    public double EmployeeBenefitFactor { get; set; }
    public double LimitedCoverageFactor { get; set; }
    public double DeductibleFactor { get; set; }

    public virtual TestDataPolicyTestingPricecheckResult? PricecheckResult { get; set; }
}
