namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboEndorsement
{
    public ProductDboEndorsement()
    {
        Coverages = new HashSet<ProductDboCoverage>();
        EndorsementConditions = new HashSet<ProductDboEndorsementCondition>();
        EndorsementForms = new HashSet<ProductDboEndorsementForm>();
        EndorsementPlans = new HashSet<ProductDboEndorsementPlan>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Guid? PriceFactorId { get; set; }

    public virtual ICollection<ProductDboCoverage> Coverages { get; set; }
    public virtual ICollection<ProductDboEndorsementCondition> EndorsementConditions { get; set; }
    public virtual ICollection<ProductDboEndorsementForm> EndorsementForms { get; set; }
    public virtual ICollection<ProductDboEndorsementPlan> EndorsementPlans { get; set; }
}
