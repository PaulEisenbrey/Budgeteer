namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicy
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public int? PolicyId { get; set; }
    public DateTime PolicyDate { get; set; }
    public string PolicyNumber { get; set; } = "";
    public string? TagNumber { get; set; }
    public int PolicyAgeId { get; set; }
    public DateTime? PolicyPaidThru { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool PremiumFrozen { get; set; }
    public int? EngineVersionId { get; set; }
    public int? ChangeUserId { get; set; }
    public int? DocumentVersionId { get; set; }
    public int? SiteVisitorId { get; set; }
    public int? SiteVisitorSessionId { get; set; }
    public int? AdjustmentMonth { get; set; }
    public int? AdjustmentYear { get; set; }
    public int? EnrollmentStatusId { get; set; }
    public Guid UniqueId { get; set; }
    public Guid? PlanId { get; set; }
    public Guid? CrmsecondaryOwnerId { get; set; }
    public decimal? CoinsurancePercentage { get; set; }
    public Guid? ProductId { get; set; }
    public DateTime? ProductEffectiveDateUtc { get; set; }

    public virtual TruDatDboPet? Pet { get; set; }
    public virtual TruDatDboPolicy? Policy { get; set; }
    public virtual TruDatDboAge? PolicyAge { get; set; }
    public virtual TruDatDboPetPolicyCancelInfo? PetPolicyCancelInfo { get; set; }
    public virtual TruDatDboPetPolicyClinic? PetPolicyClinic { get; set; }
    public virtual TruDatDboPetPolicyPartner? PetPolicyPartner { get; set; }
    public virtual TruDatDboPetPolicyReferral? PetPolicyReferral { get; set; }
    public virtual TruDatDboPetPolicyVoucher? PetPolicyVoucher { get; set; }
    public virtual TruDatDboPetPolicyWebPartner? PetPolicyWebPartner { get; set; }
    public virtual List<TruDatDboClaim> Claims { get; set; } = new();
    public virtual List<TruDatDboPetPolicyAction> PetPolicyActions { get; set; } = new();
    public virtual List<TruDatDboPetPolicyAssociation> PetPolicyAssociations { get; set; } = new();
    public virtual List<TruDatDboPetPolicyAttribute> PetPolicyAttributes { get; set; } = new();
    public virtual List<TruDatDboPetPolicyCost> PetPolicyCosts { get; set; } = new();
    public virtual List<TruDatDboPetPolicyRateAdjustment> PetPolicyRateAdjustments { get; set; } = new();
    public virtual List<TruDatDboPetPolicyRateFactorEffective> PetPolicyRateFactorEffectives { get; set; } = new();
    public virtual List<TruDatDboPetPolicyRatePendingChange> PetPolicyRatePendingChanges { get; set; } = new();
    public virtual List<TruDatDboPetPolicyTagNumber> PetPolicyTagNumbers { get; set; } = new();
}
