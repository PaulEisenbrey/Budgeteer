using Database.BaseClasses.Interfaces;
using Database.BaseClasses;
using Utilities.Logging;
using Database.TestData.PurchaseProcessDbo;
using Utilities.ReturnType;
using Database.Trupanion.Projections.PurchaseProcess.Dbo;
using Utilities.ArgumentEvaluation;
using Database.Trupanion.Entity.PurchaseProcess.Dbo;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Database.Trupanion.Entity.Quote.Dbo;

namespace Database.Trupanion.Crud.PurchaseProcess.Dbo;

public class PurchaseProcessDboProjectionCrud : QaLibCrud, IQaLibCrud, IPurchaseProcessDboProjectionCrud
{
    public PurchaseProcessDboProjectionCrud(ILogManager logMgr) : base(logMgr)
    {
        
    }

    public async Task<ReturnValue<PPDboEnrollmentDatumProjection>> RetrievePurchaseProcessEnrollmentProjectionByPolicyNumberAsync(string policyNumber, PurchaseProcessDboContext? context = null)
    {
        EvaluateArgument.Execute(policyNumber, fn => !string.IsNullOrEmpty(policyNumber), "Policy Number must be a valid string");

        try
        {
            var enrollData = await this.EnsureContext(context).EnrollmentData.
                Select(ed => new PPDboEnrollmentDatumProjection
                {
                    Active = ed.Active,
                    Address = ed.Address,
                    Address2 = ed.Address2,
                    City = ed.City,
                    Effective = ed.Effective,
                    EmailAddress = ed.EmailAddress,
                    EnrollEffective = ed.EnrollEffective,
                    ExternalAccountId = ed.ExternalAccountId,
                    FirstName = ed.FirstName,
                    LastName = ed.LastName,
                    Id = ed.Id,
                    PolicyHolderId = ed.PolicyHolderId,
                    PostalCode = ed.PostalCode,
                    PrimaryPhone = ed.PrimaryPhone,
                    PolicyNumber = ed.PolicyNumber
                })
                .FirstOrDefaultAsync(ed => ed.PolicyNumber == policyNumber)
                .ConfigureAwait(false);

            EvaluateArgument.Execute(enrollData, fn => null != enrollData, $"No Enrollment data found for policy {policyNumber}");

            return ReturnValue<PPDboEnrollmentDatumProjection>.From(enrollData!);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<PPDboEnrollmentDatumProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (ArgumentException aex)
        {
            Logger?.WriteError(aex);
            return ReturnValue<PPDboEnrollmentDatumProjection>.FromError(aex);
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<PPDboEnrollmentDatumProjection>.FromError(ex);
        }
    }
}
