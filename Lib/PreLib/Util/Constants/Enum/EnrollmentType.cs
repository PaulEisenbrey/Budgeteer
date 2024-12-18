using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum EnrollmentType
{
    [Description("EnrollmentType_FullEnrollmentCollectPayment")]
    FullEnrollmentCollectPayment = 1,

    [Description("EnrollmentType_TrialActivation")]
    TrialActivation,

    [Description("EnrollmentType_TrialUpgradeCollectPayment")]
    TrialUpgradeCollectPayment,

    [Description("EnrollmentType_IssueCertificate")]
    IssueCertificate,

    [Description("EnrollmentType_AddPetSkipPayment")]
    AddPetSkipPayment,

    [Description("EnrollmentType_AddTrial")]
    AddTrial,

    [Description("EnrollmentType_TrialUpgradeSkipPayment")]
    TrialUpgradeSkipPayment,

    [Description("EnrollmentType_AddPetCollectPayment")]
    AddPetCollectPayment,

    [Description("EnrollmentType_FullEnrollmentSkipPayment")]
    FullEnrollmentSkipPayment,

    [Description("EnrollmentType_IssueCertificateToExistingPolicyHolder")]
    IssueCertificateToExistingPolicyHolder,

    [Description("EnrollmentType_PartialEnrollment")]
    PartialEnrollment,

    [Description("EnrollmentType_PartialEnrollmentComplete")]
    PartialEnrollmentComplete
}