namespace Utilities.EntityBaseClasses;

public class EntityGuidId : IIdentity<Guid>
{
    public virtual Guid Id { get; set; }
}
