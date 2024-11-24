using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimInvoiceLineItem : EntityIntId
{
    public int InvoiceId { get; set; }

    public string? Description { get; set; }

    public int? InvoiceCategoryId { get; set; }

    public decimal? Amount { get; set; }

    public decimal? ExcludedAmount { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

    public string? CalcString { get; set; }

    public decimal? Deductible { get; set; }

    public string? Comments { get; set; }

    public bool? NotCondition { get; set; }

    public int? InvoiceLineItemCategoryId { get; set; }

    public decimal? AmountBeforeDiscount { get; set; }

}
