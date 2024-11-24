using Database.TestData.PurchaseProcessDbo;
using Database.Trupanion.Entity.PurchaseProcess.Dbo;
using Utilities.Constants.Enum;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.PurchaseProcess.Dbo
{
    public interface IPurchaseProcessDboCrud
    {
        ReturnValue<string> RetrieveNextPolicyNumber(PriceEngine priceEngine, PurchaseProcessDboContext? context = null);
        Task<ReturnValue<PPDboEnrollmentDatum>> SaveEnrollmentDataAsync(PPDboEnrollmentDatum newEnrollment, PurchaseProcessDboContext? context = null);
    }
}