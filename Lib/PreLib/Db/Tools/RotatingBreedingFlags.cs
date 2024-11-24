using Database.Tools.Interfaces;
using Utilities.Constants.Enum;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.Tools.Interfaces;

namespace Database.Tools;

public class RotatingBreedingFlags : RotatingValueBase<BreedingConstants>, IRotatingValue<BreedingConstants>, IRotatingBreedingFlags, ISingletonSvc
{
    public RotatingBreedingFlags(ILogManager logManager) : base(logManager)
    {
        // Make sure this is not just an A-B rotation.
        this.Initialize(new List<BreedingConstants>()
            {
                BreedingConstants.Intact,
                BreedingConstants.SpayNeuter,
                BreedingConstants.SpayNeuter,
                BreedingConstants.Intact,
                BreedingConstants.Intact,
                BreedingConstants.Intact,
                BreedingConstants.SpayNeuter,
                BreedingConstants.SpayNeuter,
                BreedingConstants.Intact,
                BreedingConstants.SpayNeuter });
    }

    public override bool HandlesType(RotatorType rt) => RotatorType.Breeding == rt;
}