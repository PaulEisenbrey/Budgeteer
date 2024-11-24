namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboOnlineClaimSubmission
{
    public int Id { get; set; }
    public int PolicyholderId { get; set; }
    public int PetId { get; set; }
    public string? PolicyNumber { get; set; }
    public DateTime SubmissionDate { get; set; }
    public bool PayToVet { get; set; }
    public bool IsFirstClaim { get; set; }
    public int UploadedFileCount { get; set; }
    public int UploadTotalSize { get; set; }
    public int LargestFileUploaded { get; set; }
}
