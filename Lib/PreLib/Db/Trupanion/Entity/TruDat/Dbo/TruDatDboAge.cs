namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAge
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal AgeYearFrom { get; set; }
    public decimal AgeYearTo { get; set; }
    public bool Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool ValidForEnrollment { get; set; }
    public Guid PetCharacteristicUniqueId { get; set; }
    public Guid ProductFactorInstanceUniqueId { get; set; }

    public virtual List<TruDatDboPetPolicy> PetPolicies { get; set; } = new();
    public virtual List<TruDatDboPetPolicyRateFactorEffective> PetPolicyRateFactorEffectives { get; set; } = new();
}
