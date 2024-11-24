namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizClaimConditionForPolicy
{
    public int Id { get; set; }
    public string ConditionName { get; set; } = "";
    public string Diagnosis { get; set; } = "";
    public int PetPolicyId { get; set; }
    public string PolicyNumber { get; set; } = "";
    public decimal? TotalClaimed { get; set; }
    public decimal? AmountPaidOut { get; set; }
    public DateTime ClaimOpenDate { get; set; }
    public DateTime? DateOfLoss { get; set; }
    public DateTime? DateClosed { get; set; }
    public string PetName { get; set; } = "";
    public string BreedName { get; set; } = "";
}
