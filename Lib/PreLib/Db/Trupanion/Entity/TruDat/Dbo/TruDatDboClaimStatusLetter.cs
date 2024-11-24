namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimStatusLetter
{
    public int Id { get; set; }
    public int ClaimStatusId { get; set; }
    public bool? ClaimsExpress { get; set; }
    public int? PaymentMethodId { get; set; }
    public int? CountryId { get; set; }
    public int TemplateId { get; set; }
    public bool Batch { get; set; }
    public bool Check { get; set; }
    public bool View { get; set; }
    public bool? AmountZero { get; set; }
    public int? EntityTypeId { get; set; }
    public bool? Email { get; set; }
    public int ChangedUserId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? EditableTemplateId { get; set; }
    public int? CheckTemplateId { get; set; }
    public bool? Trex { get; set; }
    public bool? IsPostRequired { get; set; }

    public virtual TruDatDboUser? ChangedUser { get; set; }
    public virtual TruDatDboStatus? ClaimStatus { get; set; }
}
