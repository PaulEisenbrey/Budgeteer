using Database.Tools.Interfaces;
using Utilities.Constants.Enum;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.Tools.Interfaces;

namespace Database.Tools;

public class RotatingRiderA : RotatingValueBase<bool>, IRotatingValue<bool>, IRotatingRiderA, ISingletonSvc
{
    public RotatingRiderA(ILogManager logManager) : base(logManager)
    {
        this.Initialize(new List<bool>() { true, true, false, true, false, false, false });
    }

    public override bool HandlesType(RotatorType rt)
    {
        return RotatorType.RiderA == rt;
    }
}