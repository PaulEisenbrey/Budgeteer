using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.TruDat.Claim;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface ITruDatClaimCrud : IQaLibCrud
{
    Task<ReturnValue<List<TruDatClaimAppealEntityNote>>> RetrieveEntityNotesByEntityNoteIdAsync(int entityNoteId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimAssessmentDataAppealReason>>> RetrieveTruDatClaimAssessmentDataAppealReasonsByAssessmentDataIdAsync(int assessmentDataAppealId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimAssessmentDataAppeal>>> RetrieveTruDatClaimAssessmentDataAppealsByAssessmentIdAsync(int assessmentDataId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimAssessmentData>>> RetrieveTruDatClaimAssessmentDataByAssessmentIdAsync(int assessmentId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimAssessmentDataHistory>>> RetrieveTruDatClaimAssessmentDataHistorysByAssessmentDataIdAsync(int assessmentDataId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimAssessmentConditionPreviousLink>>> RetrieveTruDatClaimAssessmentPreviousLinksByEntityIdAndTypeAsync(int entityId, int entityTypeId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimAssessment>>> RetrieveTruDatClaimAssessmentsByClaimIdAsync(int claimId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimClinicClaimFrom>>> RetrieveTruDatClaimClinicsClaimFromByAssessmentDataIdAsync(int assessmentDataId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimClaimHistory>>> RetrieveTruDatClaimHistorysByClaimIdAsync(int claimId, TruDatClaimContext? context = null);
    Task<ReturnValue<TruDatClaimInvoice>> RetrieveTruDatClaimInvoiceAssessmentDataIdAsync(int assessmentDataId, TruDatClaimContext? context = null);
    Task<ReturnValue<TruDatClaimInvoice>> RetrieveTruDatClaimInvoiceByAssessmentDataIdAsync(int assessmentDataId, TruDatClaimContext? context = null);
    Task<ReturnValue<TruDatClaimInvoiceLineItemCondition>> RetrieveTruDatClaimInvoiceLineItemConditionByInvoiceLineItemIdAsync(int invoiceLineItemId, TruDatClaimContext? context = null);
    Task<ReturnValue<TruDatClaimInvoiceLineItemDiscount>> RetrieveTruDatClaimInvoiceLineItemDiscountByInvoiceLineItemIdAsync(int invoiceLineItemId, TruDatClaimContext? context = null);
    Task<ReturnValue<TruDatClaimInvoiceLineItemExclusion>> RetrieveTruDatClaimInvoiceLineItemExclusionByInvoiceLineItemIdAsync(int invoiceLineItemId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimInvoiceLineItem>>> RetrieveTruDatClaimInvoiceLineItemsByInvoiceIdAsync(int invoiceId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimClinicInvoiceLineItem>>> RetrieveTruDatClaimInvoiceLineItesmByInvoiceIdAsync(string invoiceId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimMedicalRecordAssessment>>> RetrieveTruDatClaimMedicalRecordAssessmentsByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimMedicalRecordCondition>>> RetrieveTruDatClaimMedicalRecordConditionsByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimMedicalRecordDiagnosis>>> RetrieveTruDatClaimMedicalRecordDiagnosesByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimMedicalRecordEligible>>> RetrieveTruDatClaimMedicalRecordEligibleByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimMedicalRecordLocation>>> RetrieveTruDatClaimMedicalRecordLocationByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimMedicalRecordProcedure>>> RetrieveTruDatClaimMedicalRecordProceduresByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimMedicalRecord>>> RetrieveTruDatClaimMedicalRecordsByEntityIdAndEntityTypeAsync(int entityId, int entityTypeId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimMedicalRecordSign>>> RetrieveTruDatClaimMedicalRecordSignsByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimMedicalRecordTreatment>>> RetrieveTruDatClaimMedicalTreatmentsByMedicalRecordIdAsync(int medicalRecordId, TruDatClaimContext? context = null);
    Task<ReturnValue<TruDatClaimPetClinic>> RetrieveTruDatClaimPetClinicByPetIdAsync(int petId, TruDatClaimContext? context = null);
    Task<ReturnValue<List<TruDatClaimPetClinic>>> RetrieveTruDatClaimPetClinicsByClinicIdAsync(int clinicId, TruDatClaimContext? context = null);
}