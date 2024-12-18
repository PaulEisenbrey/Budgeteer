namespace Utilities.Helpers;

public class Money : ValueObject<Money>
{
    public decimal Amount { get; }

    public Currency CurrencyValue { get; }

    private Money(decimal amount, string isoCurrencySymbol)
        : this(amount, Currency.From(isoCurrencySymbol))
    {
    }

    public Money(decimal amount, Currency currency)
    {
        CurrencyValue = currency;
        Amount = Math.Round(amount, currency.DecimalPlaces);
    }

    public override string ToString() => $"{CurrencyValue.CurrencySymbol}{Amount}";

    public static implicit operator decimal(Money money) => money.Amount;

    public static Money operator -(Money money1, decimal money2) =>
        new Money(money1.Amount - money2, money1.CurrencyValue);

    public static Money operator +(Money money1, decimal money2) =>
        new Money(money1.Amount + money2, money1.CurrencyValue);

    public static Money Create(decimal amount, string isoCurrencySymbol) =>
        new Money(amount, isoCurrencySymbol);

    public static Money Create(decimal amount, Currency currency) => new Money(amount, currency);

    public MoneySerializable ToMoneySerializable() =>
        new MoneySerializable(Amount, CurrencyValue.IsoCurrencySymbol);
}