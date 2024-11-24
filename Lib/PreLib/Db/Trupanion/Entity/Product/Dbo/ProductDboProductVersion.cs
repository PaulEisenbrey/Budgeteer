namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboProductVersion
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid? TemplateId { get; set; }
    public Guid? ApprovalId { get; set; }
    public Guid ProductId { get; set; }
    public string? VersionName { get; set; }
    public string? VersionNumber { get; set; }
    public decimal? RateCapPercentage { get; set; }
    public Guid UnderwriterId { get; set; }
    public int ProductRevisionNumber { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboProduct? Product { get; set; }
    public virtual ProductDboProductVersion? Template { get; set; }
    public virtual ProductDboUnderwriter? Underwriter { get; set; }
    public virtual List<ProductDboCharacteristicToProductVersionMap> CharacteristicToProductVersionMaps { get; set; } = new();
    public virtual List<ProductDboForm> Forms { get; set; } = new();
    public virtual List<ProductDboProductVersion> InverseTemplate { get; set; } = new();
    public virtual List<ProductDboPlan> Plans { get; set; } = new();
    public virtual List<ProductDboProductVersionProductFactor> ProductVersionProductFactors { get; set; } = new();
}
