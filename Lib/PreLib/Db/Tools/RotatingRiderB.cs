using Database.Tools.Interfaces;
using Utilities.Constants.Enum;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.Tools.Interfaces;

namespace Database.Tools;

public class RotatingRiderB : RotatingValueBase<bool>, IRotatingValue<bool>, IRotatingRiderB, ISingletonSvc
{
    public RotatingRiderB(ILogManager logManager) : base(logManager)
    {
        this.Initialize(new List<bool>() { false, false, true, false, true, true, true });
    }

    public override bool HandlesType(RotatorType rt)
    {
        return RotatorType.RiderB == rt;
    }
}