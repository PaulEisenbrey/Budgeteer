using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum AquariumUKCountryParts
{
    UnInitialized = 0,

    [Description("England")]
    England = 1,

    [Description("Wales")]
    Wales = 2,

    [Description("Scotland")]
    Scotland = 3,

    [Description("Northern Ireland")]
    NorthernIreland = 4,

    OutOfRange
}