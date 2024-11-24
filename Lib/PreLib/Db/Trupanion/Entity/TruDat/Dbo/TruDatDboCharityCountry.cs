namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCharityCountry
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public int CharityId { get; set; }

    public virtual TruDatDboCharity? Charity { get; set; }
    public virtual TruDatDboCountry? Country { get; set; }
}
