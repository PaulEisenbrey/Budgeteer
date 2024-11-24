using Database.Tools.Interfaces;
using Utilities.Constants.Enum;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.Tools.Interfaces;

namespace Database.Tools;

public class RotatingBool : RotatingValueBase<bool>, IRotatingValue<bool>, IRotatingBool, ISingletonSvc
{
    public RotatingBool(ILogManager logMan) : base(logMan)
    {
        this.Initialize(new List<bool>() { false, true, true, false, false, false, true, true, true });
    }

    public override bool HandlesType(RotatorType t) => t == RotatorType.Bool;
}
