namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizHowDidYouHearAboutU
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Sort { get; set; }
    public bool Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool? HospitalRequired { get; set; }
}
