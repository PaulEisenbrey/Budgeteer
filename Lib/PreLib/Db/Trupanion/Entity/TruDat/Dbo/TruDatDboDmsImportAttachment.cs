namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboDmsImportAttachment
{
    public int Id { get; set; }
    public int AttachmentId { get; set; }
    public string? FileName { get; set; }
    public int InputTypeId { get; set; }
    public int CategoryId { get; set; }
    public int DocTypeId { get; set; }
    public string? Description { get; set; }
    public bool TombStoned { get; set; }
    public DateTime AddedOnPst { get; set; }
    public int? AddedBy { get; set; }
    public bool? IsFax { get; set; }
    public int? FaxDuration { get; set; }
    public string? FaxSendingNumber { get; set; }
    public DateTime? FaxReceivedOnPst { get; set; }
    public int? FaxLineNumberId { get; set; }
    public int? FaxSourceCountryId { get; set; }
    public int? FaxSourceStateId { get; set; }
    public int? FaxSourceHospitalId { get; set; }
    public string? FaxSourceHospitalName { get; set; }
    public int? FaxRightFaxId { get; set; }
    public string? FaxProtusFaxId { get; set; }
    public int? FaxPageCount { get; set; }
    public int? PetHospitalId { get; set; }
    public string? DocumentId { get; set; }
    public string? FaxReceivingNumber { get; set; }
}
