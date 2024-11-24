namespace Database.Trupanion.Entity.TruDat.ClaimBot;

public class TruDatClaimBotCcilimapDaily
{
    public int Id { get; set; }
    public int ClaimId { get; set; }
    public int? CiliMap { get; set; }
    public int CciliId { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public DateTime? UploadedOn { get; set; }
    public bool? PreappFlag { get; set; }
    public bool? TruxFlag { get; set; }
    public bool? DiscountFlag { get; set; }
}
