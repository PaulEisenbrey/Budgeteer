namespace Utilities.EntityBaseClasses;

public class EntityIntId : IIdentity<int>
{
    public virtual int Id { get; set; }
}