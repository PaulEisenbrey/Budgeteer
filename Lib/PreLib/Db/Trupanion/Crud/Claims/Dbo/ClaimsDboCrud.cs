using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.Claims.Dbo;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Claims.Dbo;

public class ClaimsDboCrud : QaLibCrud, IQaLibCrud, IClaimsDboCrud
{
    public ClaimsDboCrud(ILogManager logMgr) : base(logMgr)
    {
    }

    public async Task<ReturnValue<ClaimsDboClinicInvoice>> RetrieveInvoiceByInvoiceIdAsync(string invoiceId, ClaimsDboContext? context = null)
    {
        try
        {
            var clinicInvoice = await this.EnsureContext(context).ClinicInvoices.FirstOrDefaultAsync(invoice => invoice.PimsinvoiceId == invoiceId).ConfigureAwait(false);
            return null == clinicInvoice
                ? ReturnValue<ClaimsDboClinicInvoice>.FromError($"Unable to locate invoice for PimsInvoiceId {invoiceId}")
                : ReturnValue<ClaimsDboClinicInvoice>.From(clinicInvoice);
        }
        catch (Exception ex)
        {
            return ReturnValue<ClaimsDboClinicInvoice>.FromError(ex);
        }
    }

    public async Task<ReturnValue<ClaimsDboClinicInvoice>> RetrieveInvoiceTreeByInvoiceIdAsync(string invoiceId, ClaimsDboContext? context = null)
    {
        try
        {
            var clinicInvoice = await this.EnsureContext(context).ClinicInvoices
                .Include(inv => inv.ClinicInvoiceLineItems)
                .FirstOrDefaultAsync(invoice => invoice.PimsinvoiceId == invoiceId).ConfigureAwait(false);
            return null == clinicInvoice
                ? ReturnValue<ClaimsDboClinicInvoice>.FromError($"Unable to locate invoice for PimsInvoiceId {invoiceId}")
                : ReturnValue<ClaimsDboClinicInvoice>.From(clinicInvoice);
        }
        catch (Exception ex)
        {
            return ReturnValue<ClaimsDboClinicInvoice>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ClaimsDboClinicInvoiceLineItem>>> RetrieveInvoiceLineItemsByInvoiceIdAsync(int invoiceId, ClaimsDboContext? context = null)
    {
        try
        {
            var clinicInvoice = await this.EnsureContext(context).ClinicInvoiceLineItems.Where(invoice => invoice.ClinicInvoiceId == invoiceId).ToListAsync().ConfigureAwait(false);
            return null == clinicInvoice
                ? ReturnValue<List<ClaimsDboClinicInvoiceLineItem>>.FromError($"Unable to locate invoice for PimsInvoiceId {invoiceId}")
                : ReturnValue<List<ClaimsDboClinicInvoiceLineItem>>.From(clinicInvoice);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ClaimsDboClinicInvoiceLineItem>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ClaimsDboClinicInvoiceLineItem>>> RetrieveInvoiceLineItemsTreeByInvoiceIdAsync(int invoiceId, ClaimsDboContext? context = null)
    {
        try
        {
            var clinicInvoice = await this.EnsureContext(context).ClinicInvoiceLineItems
                .Include(inv => inv.ClinicInvoice)
                .Where(invoice => invoice.ClinicInvoiceId == invoiceId).ToListAsync().ConfigureAwait(false);
            return null == clinicInvoice
                ? ReturnValue<List<ClaimsDboClinicInvoiceLineItem>>.FromError($"Unable to locate invoice for PimsInvoiceId {invoiceId}")
                : ReturnValue<List<ClaimsDboClinicInvoiceLineItem>>.From(clinicInvoice);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ClaimsDboClinicInvoiceLineItem>>.FromError(ex);
        }
    }
}