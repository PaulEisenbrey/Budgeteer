namespace Database.TestData.TruDatPayment;

public  class TruDataPaymentAccount
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public string? AccountNumber { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? EntityTypeId { get; set; }

    public virtual List<TruDataPaymentEntityPaymentGroup> EntityPaymentGroups { get; set; } = new();
}
