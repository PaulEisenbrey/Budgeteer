namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPolicy
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal MinDeductible { get; set; }
    public decimal MaxDeductible { get; set; }
    public decimal? MaximumLifetimeBenefitsPayment { get; set; }
    public decimal CoinsurancePercentage { get; set; }
    public int WaitingPeriodForAccident { get; set; }
    public int WaitingPeriodForIllness { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboAssociatePolicy> AssociatePolicies { get; set; } = new();
    public virtual List<TruDatDboPetPolicy> PetPolicies { get; set; } = new();
    public virtual List<TruDatDboPetPolicyRateFactorEffective> PetPolicyRateFactorEffectives { get; set; } = new();
    public virtual List<TruDatDboPolicyAttribute> PolicyAttributes { get; set; } = new();
    public virtual List<TruDatDboPolicyOption> PolicyOptions { get; set; } = new();
    public virtual List<TruDatDboPolicyRequiredDoc> PolicyRequiredDocs { get; set; } = new();
}
