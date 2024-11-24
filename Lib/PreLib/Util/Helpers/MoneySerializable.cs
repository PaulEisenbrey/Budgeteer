using Utilities.ArgumentEvaluation;

namespace Utilities.Helpers;

public class MoneySerializable
{
    public MoneySerializable()
    {
    }

    public MoneySerializable(decimal amount, string isoCurrencySymbol)
    {
        EvaluateArgument.Execute(isoCurrencySymbol, fn => default != isoCurrencySymbol, "Currency symbol cannot have default value.");

        Amount = amount;
        IsoCurrencySymbol = isoCurrencySymbol;
    }

    public decimal Amount { get; set; }

    public string IsoCurrencySymbol { get; set; } = "";

    public Money ToMoney()
    {
        return Money.Create(Amount, IsoCurrencySymbol);
    }

    public static bool AreValuesEqual(MoneySerializable moneySerializable1, MoneySerializable moneySerializable2)
    {
        if (moneySerializable1 == moneySerializable2)
        {
            return true;
        }

        if (moneySerializable1 == null || moneySerializable2 == null)
        {
            return false;
        }

        return moneySerializable1.Amount == moneySerializable2.Amount && moneySerializable1.IsoCurrencySymbol == moneySerializable2.IsoCurrencySymbol;
    }
}