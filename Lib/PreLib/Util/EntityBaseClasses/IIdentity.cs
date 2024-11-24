namespace Utilities.EntityBaseClasses;

public interface IIdentity<TKey>
{
    TKey Id { get; set; }
}