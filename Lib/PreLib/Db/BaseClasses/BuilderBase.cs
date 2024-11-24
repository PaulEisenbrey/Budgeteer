namespace Database.BaseClasses;

public class BuilderBase<T> where T : class, new()
{
    protected T _entity = Activator.CreateInstance<T>();

    public virtual T Build => _entity;

    protected void FillValue<TV>(TV? input, ref TV output)
        where TV : class
    {
        if (default != input)
        {
            output = input;
        }
    }

    protected void FillValue<TV, TU>(TV? input, Func<TV, TU> fn)
        where TV : class
    {
        if (default != input)
        {
            fn.Invoke(input);
        }
    }

    protected void FillList<TV, TU>(List<TV> input, Func<ICollection<TV>, TU> fn)
        where TV : class
    {
        if (input.Any())
        {
            fn.Invoke(input);
        }
    }

    protected void AddToList<TT, TU>(List<TT> input, Func<List<TT>, TU> fn)
        where TT : class
    {
        if (input.Any())
        {
            fn.Invoke(input);
        }
    }

    protected void FillList<TV>(List<TV> input, ICollection<TV> output)
        where TV : class
    {
        if (input.Any())
        {
            input.ForEach(output.Add);
        }
    }
}