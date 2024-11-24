namespace Database.TestData.VisionMigrationClaims;

public class VMClaimsSharedPolicyTermRequestDatum
{
    public Guid Ref { get; set; }
    public int PetPolicyId { get; set; }
    public string? ProductCode { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Status { get; set; }
    public decimal? FixedExcessLimit { get; set; }
    public decimal? CoInsuranceLimit { get; set; }
    public decimal? SectionLimit { get; set; }
    public decimal? ConditionLimit { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsBaseProduct { get; set; }
}
