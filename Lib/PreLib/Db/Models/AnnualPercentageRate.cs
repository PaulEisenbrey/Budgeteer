namespace Database.Models;

public partial class AnnualPercentageRate
{
    public int Id { get; set; }

    public int AccountDatumId { get; set; }

    public decimal Apr { get; set; }

    public DateTime EffectiveDate { get; set; }

    public virtual AccountDatum AccountDatum { get; set; } = new();
}