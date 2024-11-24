namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboObservation
{
    public int ObservationId { get; set; }
    public int? ObservationTypeId { get; set; }
    public int? OccurrenceTypeId { get; set; }
    public int? SignificanceTypeId { get; set; }
    public int? RelationshipTypeId { get; set; }
    public int? ClaimId { get; set; }
    public string? Description { get; set; }
    public DateTime? DateObserved { get; set; }
    public int? PetId { get; set; }
    public bool? IsDiagnosis { get; set; }
    public string? AddedBy { get; set; }
    public string? AddedById { get; set; }
    public DateTime? DateAdded { get; set; }
    public bool? Active { get; set; }
    public int? ChangeUserId { get; set; }
}
