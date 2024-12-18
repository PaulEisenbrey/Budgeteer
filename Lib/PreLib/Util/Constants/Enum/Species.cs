using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum Species
{
    Uninitialized,

    [Description("Dog")]
    Dog,

    [Description("Cat")]
    Cat
}