using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.TruDat.Claim;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.TruDat.Claim;

public class TruDatClaimCrud : QaLibCrud, IQaLibCrud, ITruDatClaimCrud
{
    public TruDatClaimCrud(ILogManager logMgr) : base(logMgr)
    {

    }

    public async Task<ReturnValue<List<TruDatClaimAppealEntityNote>>> RetrieveEntityNotesByEntityNoteIdAsync(int entityNoteId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(entityNoteId, fn => 0 < entityNoteId, "Entity Note Id must be a positive integer");
        try
        {
            Expression<Func<TruDatClaimAppealEntityNote, bool>> predicate = aen => aen.EntityNoteId == entityNoteId;
            var appealNotes = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(appealNotes, $"Null result from Entity Notes query for Id {entityNoteId}", $"No Entity Notes found for Entity Note Id {entityNoteId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimAppealEntityNote>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimAppealEntityNote>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimAssessment>>> RetrieveTruDatClaimAssessmentsByClaimIdAsync(int claimId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(claimId, fn => 0 < claimId, "Claim Id must be a positive integer");
        try
        {
            Expression<Func<TruDatClaimAssessment, bool>> predicate = assmt => assmt.ClaimId == claimId;
            var assessments = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(assessments, $"No Results found for Claim Id {claimId}", $"Unable to find Assessment for Claim Id {claimId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimAssessment>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimAssessment>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimAssessmentConditionPreviousLink>>> RetrieveTruDatClaimAssessmentPreviousLinksByEntityIdAndTypeAsync(int entityId, int entityTypeId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(entityId, fn => 0 < entityId, "Entity Id must be a positive integer");
        EvaluateArgument.Execute(entityTypeId, fn => 0 < entityTypeId, "Entity Type Id must be a positive integer");

        try
        {
            Expression<Func<TruDatClaimAssessmentConditionPreviousLink, bool>> predicate = cpl => cpl.EntityId == entityId && cpl.EntityTypeId == entityTypeId;
            var previousLinks = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(previousLinks,
                $"Unable to find Assessment Prior Links for Entity Id {entityId} and Entity Type {entityTypeId}",
                $"No Assessment Prior Links found for Entity Id {entityId}, and entityTypeId {entityTypeId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimAssessmentConditionPreviousLink>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimAssessmentConditionPreviousLink>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimAssessmentData>>> RetrieveTruDatClaimAssessmentDataByAssessmentIdAsync(int assessmentId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(assessmentId, fn => 0 < assessmentId, "Assessment Id must be a positive integer");
        try
        {
            Expression<Func<TruDatClaimAssessmentData, bool>> predicate = ad => ad.AssessmentId == assessmentId;
            var assessmentDatas = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(assessmentDatas,
                $"NULL Assessment Data for Assessment Id {assessmentId}",
                $"Unable to find Assessment Data for Assessment Id {assessmentId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimAssessmentData>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimAssessmentData>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimAssessmentDataAppeal>>> RetrieveTruDatClaimAssessmentDataAppealsByAssessmentIdAsync(int assessmentDataId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(assessmentDataId, fn => 0 < assessmentDataId, "Assessment Data Id must be a positive integer");
        try
        {
            Expression<Func<TruDatClaimAssessmentDataAppeal, bool>> predicate = ada => ada.AssessmentDataId == assessmentDataId;
            var assessmentDatas = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(assessmentDatas,
                $"NULL Assessment Appeal for Assessment Data Id {assessmentDataId}",
                $"Unable to find Assessment Appeal for Assessment Data Id {assessmentDataId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimAssessmentDataAppeal>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimAssessmentDataAppeal>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimAssessmentDataAppealReason>>> RetrieveTruDatClaimAssessmentDataAppealReasonsByAssessmentDataIdAsync(int assessmentDataAppealId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(assessmentDataAppealId, fn => 0 < assessmentDataAppealId, "Assessment Data Appeal Id must be a positive integer");
        try
        {
            Expression<Func<TruDatClaimAssessmentDataAppealReason, bool>> predicate = dar => dar.AssessmentDataAppealId == assessmentDataAppealId;
            var assessmentDataReasons = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(assessmentDataReasons,
                $"NULL retrieve from Assessment Appeal for Assessment Data Appeal Id {assessmentDataAppealId}",
                $"Unable to find Assessment Appeal for Assessment Data Appeal Id {assessmentDataAppealId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimAssessmentDataAppealReason>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimAssessmentDataAppealReason>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimAssessmentDataHistory>>> RetrieveTruDatClaimAssessmentDataHistorysByAssessmentDataIdAsync(int assessmentDataId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(assessmentDataId, fn => 0 < assessmentDataId, "Assessment Data Id must be a positive integer");
        try
        {
            Expression<Func<TruDatClaimAssessmentDataHistory, bool>> predicate = adh => adh.AssessmentDataId == assessmentDataId;
            var assessmentDataHistories = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(assessmentDataHistories,
                $"NULL result from retrieving Assessment Data Histories for Assessment Data Id {assessmentDataId}",
                $"Unable to find Assessment Data Histories for Assessment Data Id {assessmentDataId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimAssessmentDataHistory>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimAssessmentDataHistory>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimClaimHistory>>> RetrieveTruDatClaimHistorysByClaimIdAsync(int claimId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(claimId, fn => 0 < claimId, "Claim Id must be a positive integer");

        try
        {
            Expression<Func<TruDatClaimClaimHistory, bool>> predicate = ch => ch.ClaimId == claimId;
            var claimHistories = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(claimHistories,
                $"NULL respo0nse acquiring Claim Histories for Claim Id {claimId}",
                $"Unable to find Claim Histories for Claim Id {claimId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimClaimHistory>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimClaimHistory>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimClinicClaimFrom>>> RetrieveTruDatClaimClinicsClaimFromByAssessmentDataIdAsync(int assessmentDataId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(assessmentDataId, fn => 0 < assessmentDataId, "Assessment Data Id must be a positive integer");

        try
        {
            Expression<Func<TruDatClaimClinicClaimFrom, bool>> predicate = cf => cf.AssessmentDataId == assessmentDataId;
            var clinicsClaimFrom = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(clinicsClaimFrom,
                $"NULL response acquiring Clinic Claims from for Assessment Data Id {assessmentDataId}",
                $"Unable to find Clinic Claims from for Assessment Data Id {assessmentDataId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimClinicClaimFrom>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimClinicClaimFrom>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatClaimInvoice>> RetrieveTruDatClaimInvoiceAssessmentDataIdAsync(int assessmentDataId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(assessmentDataId, fn => 0 < assessmentDataId, "Assessment Data Id must be a positive integer");

        try
        {
            Expression<Func<TruDatClaimInvoice, bool>> predicate = i => i.AssessmentDataId == assessmentDataId;
            var clinicsClaimFrom = await this.RetrieveByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(clinicsClaimFrom, $"Unable to find Claim Invoice from for Assessment Data Id {assessmentDataId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatClaimInvoice>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatClaimInvoice>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimClinicInvoiceLineItem>>> RetrieveTruDatClaimInvoiceLineItesmByInvoiceIdAsync(string invoiceId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(invoiceId, fn => !string.IsNullOrEmpty(invoiceId), "Invoice Id must be a valid string");

        try
        {
            Expression<Func<TruDatClaimClinicInvoiceLineItem, bool>> predicate = cf => cf.InvoiceNumber == invoiceId;
            var clinicInvoiceLineItems = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(clinicInvoiceLineItems,
                $"NULL Response acquiring Clinic Invoice Line Items from for Invoice Id {invoiceId}",
                $"Unable to find Clinic Invoice Line Items from for Invoice Id {invoiceId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimClinicInvoiceLineItem>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimClinicInvoiceLineItem>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatClaimInvoice>> RetrieveTruDatClaimInvoiceByAssessmentDataIdAsync(int assessmentDataId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(assessmentDataId, fn => 0 < assessmentDataId, "Assessment Data Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimInvoice, bool>> predicate = ci => ci.AssessmentDataId == assessmentDataId;
            var invoice = await this.RetrieveByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(invoice, $"Unable to find the Invoice from for Assessment Data Id {assessmentDataId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatClaimInvoice>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatClaimInvoice>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimInvoiceLineItem>>> RetrieveTruDatClaimInvoiceLineItemsByInvoiceIdAsync(int invoiceId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(invoiceId, fn => 0 < invoiceId, "Invoice Id must be a valid positive integer");

        try
        {
            var invoiceLineItems = await this.EnsureContext(context).InvoiceLineItems.Where(ili => ili.InvoiceId == invoiceId).ToListAsync().ConfigureAwait(false);

            return null == invoiceLineItems
                ? ReturnValue<List<TruDatClaimInvoiceLineItem>>.FromError($"Unable to find the Invoice Line Items from for Invoice Id {invoiceId}")
                : ReturnValue<List<TruDatClaimInvoiceLineItem>>.From(invoiceLineItems);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimInvoiceLineItem>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimInvoiceLineItem>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatClaimInvoiceLineItemCondition>> RetrieveTruDatClaimInvoiceLineItemConditionByInvoiceLineItemIdAsync(int invoiceLineItemId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(invoiceLineItemId, fn => 0 < invoiceLineItemId, "Invoice Line Item Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimInvoiceLineItemCondition, bool>> predicate = ilic => ilic.InvoiceLineItemId == invoiceLineItemId;
            var invoiceLineItemCondition = await this.RetrieveByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(invoiceLineItemCondition,
                $"Unable to find the Invoice Line Item Condition from for Invoice Line Item Id {invoiceLineItemId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatClaimInvoiceLineItemCondition>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatClaimInvoiceLineItemCondition>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatClaimInvoiceLineItemDiscount>> RetrieveTruDatClaimInvoiceLineItemDiscountByInvoiceLineItemIdAsync(int invoiceLineItemId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(invoiceLineItemId, fn => 0 < invoiceLineItemId, "Invoice Line Item Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimInvoiceLineItemDiscount, bool>> predicate = ilic => ilic.InvoiceLineItemId == invoiceLineItemId;
            var invoiceLineItemDiscount = await this.RetrieveByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(invoiceLineItemDiscount,
                            $"Unable to find the Invoice Line Item Discount from for Invoice Line Item Id {invoiceLineItemId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatClaimInvoiceLineItemDiscount>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatClaimInvoiceLineItemDiscount>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatClaimInvoiceLineItemExclusion>> RetrieveTruDatClaimInvoiceLineItemExclusionByInvoiceLineItemIdAsync(int invoiceLineItemId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(invoiceLineItemId, fn => 0 < invoiceLineItemId, "Invoice Line Item Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimInvoiceLineItemExclusion, bool>> predicate = ilie => ilie.InvoiceLineItemId == invoiceLineItemId;
            var invoiceLineItemExclusion = await this.RetrieveByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(invoiceLineItemExclusion,
                $"Unable to find the Invoice Line Item Exclusion from for Invoice Line Item Id {invoiceLineItemId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatClaimInvoiceLineItemExclusion>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatClaimInvoiceLineItemExclusion>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimMedicalRecord>>> RetrieveTruDatClaimMedicalRecordsByEntityIdAndEntityTypeAsync(
        int entityId,
        int entityTypeId,
        TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(entityId, fn => 0 < entityId, "Entity Id must be a valid positive integer");
        EvaluateArgument.Execute(entityTypeId, fn => 0 < entityTypeId, "Entity Type Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimMedicalRecord, bool>> predicate = mr => mr.EntityId == entityId && mr.EntityTypeId == entityTypeId;
            var invoiceLineItemExclusion = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(invoiceLineItemExclusion,
                $"NULL Response acquiring the Medical Record from for Entity Id {entityId} and Entity Type Id {entityTypeId}",
                $"Unable to find the Medical Record from for Entity Id {entityId} and Entity Type Id {entityTypeId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimMedicalRecord>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimMedicalRecord>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimMedicalRecordAssessment>>> RetrieveTruDatClaimMedicalRecordAssessmentsByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(medicalRecordId, fn => 0 < medicalRecordId, "Medical Record Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimMedicalRecordAssessment, bool>> predicate = mra => mra.MedicalRecordId == medicalRecordId;
            var medicalRecordAssessments = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(medicalRecordAssessments,
                $"NULL response acquiring the Medical Record Assessments from for Medical Record Id {medicalRecordId}",
                $"Unable to find the Medical Record Assessments from for Medical Record Id {medicalRecordId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimMedicalRecordAssessment>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimMedicalRecordAssessment>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimMedicalRecordCondition>>> RetrieveTruDatClaimMedicalRecordConditionsByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(medicalRecordId, fn => 0 < medicalRecordId, "Medical Record Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimMedicalRecordCondition, bool>> predicate = mra => mra.MedicalRecordId == medicalRecordId;
            var medicalRecordConditions = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(medicalRecordConditions,
                $"NULL Response acquiring the Medical Record Conditions from for Medical Record Id {medicalRecordId}",
                $"Unable to find the Medical Record Conditions from for Medical Record Id {medicalRecordId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimMedicalRecordCondition>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimMedicalRecordCondition>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimMedicalRecordDiagnosis>>> RetrieveTruDatClaimMedicalRecordDiagnosesByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(medicalRecordId, fn => 0 < medicalRecordId, "Medical Record Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimMedicalRecordDiagnosis, bool>> predicate = mrd => mrd.MedicalRecordId == medicalRecordId;
            var medicalRecordDiagnosis = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(medicalRecordDiagnosis,
                $"NULL Response acquiring the Medical Record Diagnosises from for Medical Record Id {medicalRecordId}",
                $"Unable to find the Medical Record Diagnosises from for Medical Record Id {medicalRecordId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimMedicalRecordDiagnosis>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimMedicalRecordDiagnosis>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimMedicalRecordEligible>>> RetrieveTruDatClaimMedicalRecordEligibleByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(medicalRecordId, fn => 0 < medicalRecordId, "Medical Record Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimMedicalRecordEligible, bool>> predicate = mrd => mrd.MedicalRecordId == medicalRecordId;
            var medicalRecordEligibles = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(medicalRecordEligibles,
                $"NULL Response acquiring the Medical Record Eligible from for Medical Record Id {medicalRecordId}",
                $"Unable to find the Medical Record Eligible from for Medical Record Id {medicalRecordId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimMedicalRecordEligible>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimMedicalRecordEligible>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimMedicalRecordLocation>>> RetrieveTruDatClaimMedicalRecordLocationByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(medicalRecordId, fn => 0 < medicalRecordId, "Medical Record Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimMedicalRecordLocation, bool>> predicate = mrd => mrd.MedicalRecordId == medicalRecordId;
            var medicalRecordLocations = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(medicalRecordLocations,
                $"NULL Response acquiring the Medical Record Locations from for Medical Record Id {medicalRecordId}",
                $"Unable to find the Medical Record Locations from for Medical Record Id {medicalRecordId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimMedicalRecordLocation>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimMedicalRecordLocation>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimMedicalRecordProcedure>>> RetrieveTruDatClaimMedicalRecordProceduresByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(medicalRecordId, fn => 0 < medicalRecordId, "Medical Record Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimMedicalRecordProcedure, bool>> predicate = mrd => mrd.MedicalRecordId == medicalRecordId;
            var medicalRecordProcedures = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(medicalRecordProcedures,
                $"NULL Response acquiring the Medical Record Procedures from for Medical Record Id {medicalRecordId}",
                $"Unable to find the Medical Record Procedures from for Medical Record Id {medicalRecordId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimMedicalRecordProcedure>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimMedicalRecordProcedure>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimMedicalRecordSign>>> RetrieveTruDatClaimMedicalRecordSignsByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(medicalRecordId, fn => 0 < medicalRecordId, "Medical Record Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimMedicalRecordSign, bool>> predicate = mrd => mrd.MedicalRecordId == medicalRecordId;
            var medicalRecordSigns = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(medicalRecordSigns,
                $"NULL Response acquiring the Medical Record Signs from for Medical Record Id {medicalRecordId}",
                $"Unable to find the Medical Record Signs from for Medical Record Id {medicalRecordId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimMedicalRecordSign>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimMedicalRecordSign>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimMedicalRecordTreatment>>> RetrieveTruDatClaimMedicalTreatmentsByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(medicalRecordId, fn => 0 < medicalRecordId, "Medical Record Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimMedicalRecordTreatment, bool>> predicate = mrd => mrd.MedicalRecordId == medicalRecordId;
            var medicalRecordTreatments = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(medicalRecordTreatments,
                $"NULL Response acquiring the Medical Record Treatments from for Medical Record Id {medicalRecordId}",
                $"Unable to find the Medical Record Treatments from for Medical Record Id {medicalRecordId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimMedicalRecordTreatment>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimMedicalRecordTreatment>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatClaimPetClinic>> RetrieveTruDatClaimPetClinicByPetIdAsync(int petId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(petId, fn => 0 < petId, "Pet Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimPetClinic, bool>> predicate = mrd => mrd.PetId == petId;
            var petClinic = await this.RetrieveByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(petClinic,
                $"NULL Response acquiring the pet Clinic from for Pet Id {petId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatClaimPetClinic>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatClaimPetClinic>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatClaimPetClinic>>> RetrieveTruDatClaimPetClinicsByClinicIdAsync(int clinicId, TruDatClaimContext? context = null)
    {
        EvaluateArgument.Execute(clinicId, fn => 0 < clinicId, "Clinic Id must be a valid positive integer");

        try
        {
            Expression<Func<TruDatClaimPetClinic, bool>> predicate = mrd => mrd.ClinicId == clinicId;
            var petClinics = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(petClinics,
                $"NULL Response acquiring the pet Clinics from for clinic Id {clinicId}",
                $"No Clinics found in pet Clinics from for clinic Id {clinicId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatClaimPetClinic>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatClaimPetClinic>>.FromError(ex);
        }
    }

    public override Task<ReturnValue<int>> UpdateAsync<T, C>(T entity, C? context = null)
        where T : class
        where C : class
    {
        throw new NotImplementedException("Update");
    }

    public override Task<ReturnValue<int>> UpdateManyAsync<T, C>(IEnumerable<T> entity, C? context = null)
        where T : class
        where C : class
    {
        throw new NotImplementedException("Update");
    }

    public override Task<ReturnValue<int>> DeleteAsync<T, C>(T entity, C? context = null)
        where T : class
        where C : class
    {
        throw new NotImplementedException("Delete");
    }
}