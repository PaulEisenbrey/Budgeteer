namespace Trupanion.Test.QaLib.Database.GeographyDbo;

public class GeographyDboState
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public string StateCode { get; set; } = "";
    public string Name { get; set; } = "";
    public decimal SetupFee { get; set; }
    public bool Active { get; set; }
    public int PriceAdjustmentNoticeDays { get; set; }
    public bool IgnoreAdjustmentOnNoPricing { get; set; }
    public bool TrialsHaveDeductibles { get; set; }
    public bool AllowTrial { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
}
