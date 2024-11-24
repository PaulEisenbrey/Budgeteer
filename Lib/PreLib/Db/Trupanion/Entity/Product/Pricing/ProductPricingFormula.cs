namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingFormula
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? Name { get; set; }
    public string? ScriptText { get; set; }

    public virtual List<ProductPricingFormulaInputFactorLink> FormulaInputFactorLinks { get; set; } = new();
    public virtual List<ProductPricingFormulaPriceFactorLink> FormulaPriceFactorLinks { get; set; } = new();
    public virtual List<ProductPricingPriceEngine> PriceEngines { get; set; } = new();
}
