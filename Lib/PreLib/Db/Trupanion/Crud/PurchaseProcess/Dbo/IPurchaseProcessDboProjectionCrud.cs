using Database.TestData.PurchaseProcessDbo;
using Database.Trupanion.Projections.PurchaseProcess.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.PurchaseProcess.Dbo
{
    public interface IPurchaseProcessDboProjectionCrud
    {
        Task<ReturnValue<PPDboEnrollmentDatumProjection>> RetrievePurchaseProcessEnrollmentProjectionByPolicyNumberAsync(string policyNumber, PurchaseProcessDboContext? context = null);
    }
}