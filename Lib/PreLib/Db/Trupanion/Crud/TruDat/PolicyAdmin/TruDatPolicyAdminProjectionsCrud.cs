using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Projections.TruDat.PolicyAdmin;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.TruDat.PolicyAdmin;

public class TruDatPolicyAdminProjectionsCrud : QaLibCrud, IQaLibCrud, ITruDatPolicyAdminProjectionsCrud
{
    public TruDatPolicyAdminProjectionsCrud(ILogManager logMgr) : base(logMgr)
    {
        
    }

    public async Task<ReturnValue<List<TruDatPolicyAdminPolicyHolderProjection>>> RetrievePolicyHolderProjectionsByEmailAsync
        (
            string email,
            TruDatPolicyAdminContext? context = null
        )
    {
        EvaluateArgument.Execute(email, fn => !string.IsNullOrEmpty(email), "Email Address cannot be empty");
        EvaluateEmailAddress.Execute(email, "Invalid Email address");
        var ctx = this.EnsureContext(context);

        var lowEmail = email.ToLower();

        try
        {
            var pHolders = await ctx.Policyholders
                .Select(ph => new TruDatPolicyAdminPolicyHolderProjection
                {
                    AlternatePhoneNumber = ph.AlternatePhoneNumber,
                    EmailAddress = ph.EmailAddress,
                    BrandId = ph.BrandId,
                    Characteristics = ph.Characteristics,
                    ElectronicPolicyDocumentsPreferred = ph.ElectronicPolicyDocumentsPreferred,
                    FirstName = ph.FirstName,
                    LastName = ph.LastName,
                    Id = ph.Id,
                    IsoAlpha3CountryCode = ph.IsoAlpha3CountryCode,
                    LanguagePreference = ph.LanguagePreference,
                    PrimaryPhoneNumber = ph.PrimaryPhoneNumber,
                    PrivacyPolicyNotificationDate = ph.PrivacyPolicyNotificationDate,
                    UserId = ph.UserId
                })
                .Where(pholder => null != pholder.EmailAddress && pholder.EmailAddress.ToLower().Equals(lowEmail))
                .ToListAsync()
                .ConfigureAwait(false);

            EvaluateArgument.Execute(pHolders, fn => null != pHolders && 0 != pHolders.Count(), $"No Policy Holders found for Email {email}");

            var policyHolders = ReturnValue<List<TruDatPolicyAdminPolicyHolderProjection>>.From(pHolders);

            return this.GenerateReturnValue(policyHolders, "NULL Return from Policy Holder Query", $"No policy holders found for email {email}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatPolicyAdminPolicyHolderProjection>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (ArgumentException aex)
        {
            Logger?.WriteError(aex);
            return ReturnValue<List<TruDatPolicyAdminPolicyHolderProjection>>.FromError(aex);
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatPolicyAdminPolicyHolderProjection>>.FromError(ex);
        }
    }
    public async Task<ReturnValue<TruDatPolicyAdminPolicyHolderProjection>> RetrievePolicyHolderProjectionsByPersonIdAsync
        (
            Guid personId,
            TruDatPolicyAdminContext? context = null
        )
    {
        EvaluateArgument.Execute(personId, fn => Guid.Empty != personId, "Person Id must be initialized");
        var ctx = this.EnsureContext(context);

        try
        {
            var pHolder = await ctx.Policyholders
                .Select(ph => new TruDatPolicyAdminPolicyHolderProjection
                {
                    AlternatePhoneNumber = ph.AlternatePhoneNumber,
                    EmailAddress = ph.EmailAddress,
                    BrandId = ph.BrandId,
                    Characteristics = ph.Characteristics,
                    ElectronicPolicyDocumentsPreferred = ph.ElectronicPolicyDocumentsPreferred,
                    FirstName = ph.FirstName,
                    LastName = ph.LastName,
                    Id = ph.Id,
                    IsoAlpha3CountryCode = ph.IsoAlpha3CountryCode,
                    LanguagePreference = ph.LanguagePreference,
                    PrimaryPhoneNumber = ph.PrimaryPhoneNumber,
                    PrivacyPolicyNotificationDate = ph.PrivacyPolicyNotificationDate,
                    UserId = ph.UserId
                })
                .FirstOrDefaultAsync(pholder => pholder.Id.Equals(personId))
                .ConfigureAwait(false);

            EvaluateArgument.Execute(pHolder, fn => null != pHolder, $"No Policy Holder found for PersonId {personId}");

            var policyHolder = ReturnValue<TruDatPolicyAdminPolicyHolderProjection>.From(pHolder!);

            return this.GenerateReturnValue(policyHolder, $"No policyholder found for person iD {personId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatPolicyAdminPolicyHolderProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (ArgumentException aex)
        {
            Logger?.WriteError(aex);
            return ReturnValue<TruDatPolicyAdminPolicyHolderProjection>.FromError(aex);
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatPolicyAdminPolicyHolderProjection>.FromError(ex);
        }
    }
}
