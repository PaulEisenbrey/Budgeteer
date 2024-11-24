namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboQuotePet
{
    public int Id { get; set; }
    public int QuoteId { get; set; }
    public decimal? Deductible { get; set; }
    public decimal? Premium { get; set; }
    public string? Name { get; set; }
    public int? BreedId { get; set; }
    public int? GenderId { get; set; }
    public int? AgeId { get; set; }
    public bool? IsSpayedNeutered { get; set; }
    public int? HospitalId { get; set; }
    public string? CampaignCode { get; set; }
    public string? CampaignCodeReferenceNumber { get; set; }
    public int? CampaignInstanceId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int? LeadPetId { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Species { get; set; }
    public string? Gender { get; set; }
    public Guid? BreedCharacteristicId { get; set; }
    public Guid? AgeBandCharacteristicId { get; set; }
    public decimal? CoinsurancePercent { get; set; }
    public Guid? WebSalesQuoteId { get; set; }
    public int? VetExamId { get; set; }
    public bool? HasNoOtherHospitals { get; set; }

    public virtual QuoteDboQuote? Quote { get; set; }
    public virtual List<QuoteDboQuoteSecondaryHospital> QuoteSecondaryHospitals { get; set; } = new();
    public virtual List<QuoteDboSecondaryHospital> SecondaryHospitals { get; set; } = new();
    public virtual List<QuoteDboSelectedPolicyOption> SelectedPolicyOptions { get; set; } = new();
    public virtual List<QuoteDboSelectedWorkingPet> SelectedWorkingPets { get; set; } = new();
}
