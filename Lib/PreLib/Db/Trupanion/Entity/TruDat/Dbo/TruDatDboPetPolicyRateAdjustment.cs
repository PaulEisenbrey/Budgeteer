namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyRateAdjustment
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public DateTime EffectiveDate { get; set; }
    public int FromEngineVersionId { get; set; }
    public int ToEngineVersionId { get; set; }
    public int? FromPolicyVersionId { get; set; }
    public int? ToPolicyVersionId { get; set; }
    public int CaseCategoryId { get; set; }
    public Guid RateGuid { get; set; }
    public bool Complete { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public decimal? UnCappedPremium { get; set; }
    public bool? Capped { get; set; }
    public bool? Active { get; set; }
    public int PolicyDocumentStatus { get; set; }

    public virtual TruDatDboEntityTree? CaseCategory { get; set; }
    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
    public virtual List<TruDatDboPetPolicyRateCommunication> PetPolicyRateCommunications { get; set; } = new();
}
