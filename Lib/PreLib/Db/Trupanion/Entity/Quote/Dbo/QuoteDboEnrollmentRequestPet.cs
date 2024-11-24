namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboEnrollmentRequestPet
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid EnrollmentId { get; set; }
    public string? Name { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public DateTime? ExamDate { get; set; }
    public DateTime? AdoptionDate { get; set; }
    public DateTime EffectiveDate { get; set; }
    public bool? IsSpayedOrNeutered { get; set; }
    public Guid PetPolicyId { get; set; }
    public string? PetPolicyNumber { get; set; }
    public Guid SelectedPlanId { get; set; }
    public Guid? HospitalUniqueId { get; set; }
    public decimal? Deductible { get; set; }
    public decimal? CoinsurancePercentage { get; set; }
    public decimal PremiumAmount { get; set; }
    public decimal PremiumTaxAmount { get; set; }
    public Guid? PremiumCalculationId { get; set; }
    public bool? HasNoOtherHospitals { get; set; }
    public Guid? ShelterId { get; set; }

    public virtual QuoteDboEnrollmentRequest? Enrollment { get; set; }
    public virtual List<QuoteDboEnrollmentPetCharacteristic> EnrollmentPetCharacteristics { get; set; } = new();
    public virtual List<QuoteDboEnrollmentPetEndorsement> EnrollmentPetEndorsements { get; set; } = new();
    public virtual List<QuoteDboEnrollmentRequestPetFee> EnrollmentRequestPetFees { get; set; } = new();
    public virtual List<QuoteDboEnrollmentRequestSecondaryHospital> EnrollmentRequestSecondaryHospitals { get; set; } = new();
    public virtual List<QuoteDboSecondaryHospital> SecondaryHospitals { get; set; } = new();
}
