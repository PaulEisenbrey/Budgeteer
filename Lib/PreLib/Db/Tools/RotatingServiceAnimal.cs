using Database.Tools.Interfaces;
using Utilities.Constants.Enum;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.Tools.Interfaces;

namespace Database.Tools;

public class RotatingServiceAnimal : RotatingValueBase<bool>, IRotatingValue<bool>, IRotatingServiceAnimal, ISingletonSvc
{
    public RotatingServiceAnimal(ILogManager logManager) : base(logManager)
    {
        this.Initialize(new List<bool>() { false, true, true, true, false, false, true });
    }

    public override bool HandlesType(RotatorType rt) => RotatorType.ServiceAnimal == rt;
}
