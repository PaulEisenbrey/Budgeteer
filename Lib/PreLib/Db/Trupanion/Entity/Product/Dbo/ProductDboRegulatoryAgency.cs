namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboRegulatoryAgency
{
    public ProductDboRegulatoryAgency()
    {
        Approvals = new HashSet<ProductDboApproval>();
        RegulatoryAgencyCultureSpecifics = new HashSet<ProductDboRegulatoryAgencyCultureSpecific>();
        RegulatoryAgencyStates = new HashSet<ProductDboRegulatoryAgencyState>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? ShortName { get; set; }
    public bool ProducerLicenseRequired { get; set; }

    public virtual ICollection<ProductDboApproval> Approvals { get; set; }
    public virtual ICollection<ProductDboRegulatoryAgencyCultureSpecific> RegulatoryAgencyCultureSpecifics { get; set; }
    public virtual ICollection<ProductDboRegulatoryAgencyState> RegulatoryAgencyStates { get; set; }
}
