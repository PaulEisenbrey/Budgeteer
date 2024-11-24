using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Projections.TruDat.TruBiz;

public class TruDatTruBizPetPolicyProjection : EntityIntId
{
    public int? PetId { get; set; }

    public int? PolicyId { get; set; }

    public DateTime? PolicyDate { get; set; }

    public string? PolicyNumber { get; set; }

    public string? TagNumber { get; set; }

    public int? PolicyAgeId { get; set; }

    public int? EngineVersionId { get; set; }

    public int? DocumentVersionId { get; set; }

    public int? AdjustmentMonth { get; set; }

    public int? AdjustmentYear { get; set; }

    public string? PromoCode { get; set; }

    public string? PromoReferenceNumber { get; set; }

    public bool? Cancelled { get; set; }

    public int? HospitalId { get; set; }

    public bool? Capped { get; set; }

    public int? EnrollmentStatusId { get; set; }
}