using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Projections.TruDat.TruBiz;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;


namespace Database.Trupanion.Crud.TruDat.TruBiz;

public class TruDatTruBizCrud : QaLibCrud, IQaLibCrud, ITruDatTruBizCrud
{
    public TruDatTruBizCrud(ILogManager logMgr) : base(logMgr)
    {
        
    }

    public async Task<ReturnValue<TruDatTruBizPetPolicyProjection>> RetrieveTruBizPetPolicyProjectionByPetIdAsync(int petId, TruDatTruBizContext? context = null)
    {
        EvaluateArgument.Execute(petId, fn => 0 < petId, "PetId must be a non-zero positive integer");

        var ctx = this.EnsureContext(context);

        try
        {
            var petPolicy = await ctx.PetPolicies
                .Select(pp => new TruDatTruBizPetPolicyProjection
                {
                    PetId = pp.PetId,
                    AdjustmentMonth = pp.AdjustmentMonth,
                    AdjustmentYear = pp.AdjustmentYear,
                    Capped = pp.Capped,
                    Cancelled = pp.Cancelled,
                    DocumentVersionId = pp.DocumentVersionId,
                    EngineVersionId = pp.EngineVersionId,
                    EnrollmentStatusId = pp.EnrollmentStatusId,
                    HospitalId = pp.HospitalId,
                    Id = pp.Id,
                    PolicyAgeId = pp.PolicyAgeId,
                    PolicyDate = pp.PolicyDate,
                    PolicyId = pp.PolicyId,
                    PolicyNumber = pp.PolicyNumber,
                    PromoCode = pp.PromoCode,
                    PromoReferenceNumber = pp.PromoReferenceNumber,
                    TagNumber = pp.TagNumber
                })
                .FirstOrDefaultAsync(pp => pp.PetId == petId)
                .ConfigureAwait(false);

            EvaluateArgument.Execute(petPolicy, fn => null != petPolicy, $"No Pet Policy found for Pet Id {petId}");

            return this.GenerateReturnValue(ReturnValue<TruDatTruBizPetPolicyProjection>.From(petPolicy!), $"No Pet Policy retrieved via PetId {petId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatTruBizPetPolicyProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatTruBizPetPolicyProjection>.FromError(ex);
        }
    }
}
