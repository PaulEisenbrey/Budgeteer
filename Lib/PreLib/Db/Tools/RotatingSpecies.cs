using Database.Tools.Interfaces;
using Utilities.Constants.Enum;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.Tools.Interfaces;

namespace Database.Tools;

public class RotatingSpecies : RotatingValueBase<Species>, IRotatingValue<Species>, IRotatingSpecies, ISingletonSvc
{
    public RotatingSpecies(ILogManager logManager) : base(logManager)
    {
        this.Initialize(new List<Species>() { Species.Cat, Species.Dog, Species.Dog, Species.Cat, Species.Cat, Species.Cat, Species.Dog, Species.Dog, Species.Dog });
    }

    public override bool HandlesType(RotatorType rt)
    {
        return RotatorType.Species == rt;
    }
}