namespace Trupanion.Test.QaLib.Database.GeographyDbo;

public class GeographyDboCountry
{
    public int Id { get; set; }
    public string CountryCode { get; set; } = "";
    public string Name { get; set; } = "";
    public string Currency { get; set; } = "";
    public string CurrencySymbol { get; set; } = "";
    public bool Active { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
}
