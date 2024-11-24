namespace Database.Trupanion.Entity.TestData.PolicyTesting;

public class TestDataPolicyTestingPricecheckScenario
{
    public TestDataPolicyTestingPricecheckScenario()
    {
        PricecheckResults = new HashSet<TestDataPolicyTestingPricecheckResult>();
    }

    public int Id { get; set; }
    public DateTime RunDate { get; set; }
    public int BreedId { get; set; }
    public int SpeciesVal { get; set; }
    public int AgeVal { get; set; }
    public int GenderVal { get; set; }
    public int StateId { get; set; }
    public string? ZipCode { get; set; }
    public decimal Deductible { get; set; }
    public bool HasRiderA { get; set; }
    public bool HasRiderB { get; set; }
    public bool IsWorkingPet { get; set; }
    public bool IsBreedingFemale { get; set; }
    public bool IsSpayed { get; set; }
    public string? PromoCode { get; set; }
    public DateTime PolicyDate { get; set; }
    public int? PriceCheckScenarioParentId { get; set; }

    public virtual ICollection<TestDataPolicyTestingPricecheckResult> PricecheckResults { get; set; }
}
