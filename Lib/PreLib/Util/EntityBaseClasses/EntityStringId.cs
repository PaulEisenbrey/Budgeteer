namespace Utilities.EntityBaseClasses;

public class EntityStringId : IIdentity<string>
{
    public virtual string Id { get; set; } = "";
}