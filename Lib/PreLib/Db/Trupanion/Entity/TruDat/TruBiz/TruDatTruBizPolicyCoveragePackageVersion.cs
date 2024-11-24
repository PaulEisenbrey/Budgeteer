namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizPolicyCoveragePackageVersion
{
    public int Id { get; set; }
    public string RegulatoryName { get; set; }  = "";
    public string MarketingName { get; set; }  = "";
    public string PreferredName { get; set; } = "";
    public int PolicyVersionId { get; set; }
    public string Description { get; set; } = "";
    public string PolicyDocumentHref { get; set; } = "";
    public int CostId { get; set; }
    public int RateId { get; set; }
    public int? Sequence { get; set; }
    public bool Active { get; set; }
    public bool? HideDuringEnrollment { get; set; }
}
