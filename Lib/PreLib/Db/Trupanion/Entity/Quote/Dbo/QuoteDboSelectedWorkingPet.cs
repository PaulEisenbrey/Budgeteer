namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboSelectedWorkingPet
{
    public int Id { get; set; }
    public int QuotePetId { get; set; }
    public int WorkingPetId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }

    public virtual QuoteDboQuotePet? QuotePet { get; set; }
}
