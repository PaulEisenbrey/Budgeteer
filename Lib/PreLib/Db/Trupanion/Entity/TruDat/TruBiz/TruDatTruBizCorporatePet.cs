namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizCorporatePet
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public int OwnerId { get; set; }
    public string Name { get; set; } = "";
    public int? EngineVersionId { get; set; }
    public int? DocumentVersionId { get; set; }
    public int? EnrollmentStatusId { get; set; }
    public decimal Deductible { get; set; }
}
