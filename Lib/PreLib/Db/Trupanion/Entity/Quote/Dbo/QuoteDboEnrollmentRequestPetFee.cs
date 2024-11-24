namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboEnrollmentRequestPetFee
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid PetId { get; set; }
    public Guid TypeId { get; set; }
    public decimal Amount { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal? Discount { get; set; }
    public Guid? WaiveReasonId { get; set; }

    public virtual QuoteDboEnrollmentRequestPet? Pet { get; set; }
}
