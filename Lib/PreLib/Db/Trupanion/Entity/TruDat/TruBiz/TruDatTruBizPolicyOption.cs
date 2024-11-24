namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizPolicyOption
{
    public int Id { get; set; }
    public int PolicyVersionId { get; set; }
    public string Name { get; set; } = "";
    public string DisplayName { get; set; } = "";
    public string PreferredName { get; set; } = "";
    public string Description { get; set; } = "";
    public string PolicyDocumentHref { get; set; } = "";
    public double? FixedCost { get; set; }
    public bool? IsFree { get; set; }
    public int CostId { get; set; }
    public bool IsOptional { get; set; }
    public bool? IsDecPageVisible { get; set; }
    public bool? OnlyEnrollmentOptions { get; set; }
}
