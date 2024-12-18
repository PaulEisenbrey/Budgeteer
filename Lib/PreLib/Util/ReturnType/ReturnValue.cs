using Utilities.ReturnType.Base;

namespace Utilities.ReturnType;

public sealed class ReturnValue<T> : ValueContainer<T>
{
    private string DefaultErrorTextIfNotValid { get; set; } = "Unknown Error";

    public T? Result => this.Value;

    public string ErrorText { get; private set; } = "";

    public new bool IsValid
    {
        get
        {
            if (!base.IsValid
                && (string.IsNullOrEmpty(this.ErrorText) && !string.IsNullOrEmpty(this.DefaultErrorTextIfNotValid)))
            {
                this.ErrorText = this.DefaultErrorTextIfNotValid;
            }

            return string.IsNullOrEmpty(this.ErrorText);
        }
    }

    public ReturnValue<T> SetValue(T value)
    {
        this.value = value;
        return this;
    }

    public ReturnValue<T> SetError(string err)
    {
        this.ErrorText = err;
        return this;
    }

    public ReturnValue<T> SetError<Ex>(Ex exception)
        where Ex : Exception
    {
        this.ErrorText = $"{exception.Message}. {exception.InnerException} {exception.StackTrace}";
        return this;
    }

    public ReturnValue<T> SetValidation(Func<T?, bool> validationFunc, string errorTextIfInvalid = "")
    {
        base.SetValidation(validationFunc);
        this.DefaultErrorTextIfNotValid = errorTextIfInvalid;
        return this;
    }

    public static ReturnValue<T> From(T result) => FromError(result, "");

    public static ReturnValue<T> FromError<TEx>(T result, TEx exception)
        where TEx : Exception =>
        FromError(result, $"{exception.Message}. {exception.InnerException} {exception.StackTrace}");

    public static ReturnValue<T> FromError<TEx>(TEx exception)
        where TEx : Exception =>
        FromError($"{exception.Message}. {exception.InnerException} {exception.StackTrace}");

    public static ReturnValue<T> FromError(T result, string err) =>
        new ReturnValue<T>().SetValue(result)
            .SetError(err);

    public static ReturnValue<T> FromError(string err) => new ReturnValue<T>().SetError(err);

    public override string ToString()
    {
        if (!this.IsValid)
        {
            return $"Error: {this.ErrorText}";
        }

        if (null != this.Result)
        {
            return $"Result: {this.Result}";
        }

#pragma warning disable CS8603 // Possible null reference return.
        return base.ToString();
#pragma warning restore CS8603 // Possible null reference return.
    }
}