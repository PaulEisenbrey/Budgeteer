namespace Database.BaseClasses.Interfaces;

public interface IBuilder<T> : IBuildable
{
    T Build { get; }
}