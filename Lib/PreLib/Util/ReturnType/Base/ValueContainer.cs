namespace Utilities.ReturnType.Base;

public class ValueContainer<T>
{
    protected Maybe<T> value;

    public ValueContainer()
    {
    }

    public ValueContainer(T value)
    {
        this.value = value;
    }

    public Func<T, bool>? Validation { get; private set; }

    public bool IsValid => value.HasValue && (Validation?.Invoke(Value!) ?? true);

    public static implicit operator T(ValueContainer<T>? value) => value ?? null;

    public static implicit operator ValueContainer<T>(T value) => new ValueContainer<T>(value);

    public T? Value => value.ValueOrDefault;

    protected void SetValidation(Func<T?, bool> validationFunc) =>
        Validation = validationFunc ?? throw new ArgumentNullException(nameof(validationFunc));
}