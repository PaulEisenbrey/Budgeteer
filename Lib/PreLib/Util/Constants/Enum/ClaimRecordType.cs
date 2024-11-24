using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum ClaimRecordType
{
    uninitialized = 0,
    [Description("Illness")]
    Illness = 1,
    [Description("Incident")]
    Incident = 2,
    [Description("Wellness")]
    Wellness = 3,
    [Description("Illness")]
    AdditionalBenefits = 4,
    [Description("Additional Benefits")]
    Other = 5,
    [Description("Eligible Condition")]
    EligibleCondition = 6,
    outofrange
}
