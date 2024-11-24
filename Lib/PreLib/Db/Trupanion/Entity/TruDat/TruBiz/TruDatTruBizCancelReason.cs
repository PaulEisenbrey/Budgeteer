namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizCancelReason
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public string Name { get; set; } = "";
    public bool Restricted { get; set; }
    public bool Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}
