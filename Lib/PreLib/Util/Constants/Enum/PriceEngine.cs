using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum PriceEngine
{
    Uninitialized = 0,

    [Description("PriceEngineUS")]
    USA = 1,

    [Description("PriceEngineCA")]
    Canada,

    [Description("PriceEngineAU")]
    Australia,

    OutOfRange
}