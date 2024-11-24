namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizAdditionalBenefit
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
}
