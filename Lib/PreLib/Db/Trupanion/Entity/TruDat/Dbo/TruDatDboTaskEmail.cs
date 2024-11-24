namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboTaskEmail
{
    public int Id { get; set; }
    public int TaskId { get; set; }
    public int TemplateId { get; set; }
    public string? EmailMessage { get; set; }
    public string? Subject { get; set; }
    public string? FromAddress { get; set; }
    public string? FromName { get; set; }
    public string? Ccaddress { get; set; }
    public string? Bccaddress { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboTask? Task { get; set; }
}
