using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.Claims.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface IClaimsDboCrud : IQaLibCrud
{
    Task<ReturnValue<ClaimsDboClinicInvoice>> RetrieveInvoiceByInvoiceIdAsync(string invoiceId, ClaimsDboContext? context = null);
    Task<ReturnValue<List<ClaimsDboClinicInvoiceLineItem>>> RetrieveInvoiceLineItemsByInvoiceIdAsync(int invoiceId, ClaimsDboContext? context = null);
    Task<ReturnValue<List<ClaimsDboClinicInvoiceLineItem>>> RetrieveInvoiceLineItemsTreeByInvoiceIdAsync(int invoiceId, ClaimsDboContext? context = null);
    Task<ReturnValue<ClaimsDboClinicInvoice>> RetrieveInvoiceTreeByInvoiceIdAsync(string invoiceId, ClaimsDboContext? context = null);
}