namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboTpquestion
{
    public int Id { get; set; }
    public string? Question { get; set; }
    public bool YesOrNo { get; set; }
    public bool Explain { get; set; }
    public bool Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}
