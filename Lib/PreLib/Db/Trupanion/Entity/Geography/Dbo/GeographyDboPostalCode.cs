namespace Trupanion.Test.QaLib.Database.GeographyDbo;

public class GeographyDboPostalCode
{
    public int Id { get; set; }
    public string PostalCode { get; set; } = "";
    public int StateId { get; set; }
    public decimal? Lat { get; set; }
    public decimal? Lon { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
}
