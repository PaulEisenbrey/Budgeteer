using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum EnrollmentStatus
{
    [Description("EnrollmentStatusCancelled")]
    Cancelled = 2,

    [Description("EnrollmentStatusTrial")]
    Trial = 3,

    [Description("EnrollmentStatusEnrolled")]
    Enrolled = 4,

    [Description("EnrollmentStatusTrialExpired")]
    TrialExpired = 24,

    [Description("EnrollmentStatusPendingCancellation")]
    PendingCancellation = 66
}