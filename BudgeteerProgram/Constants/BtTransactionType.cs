namespace Budgeteer.Constants
{
    public enum BtTransactionType
    {
        unintialized = 0,
        atmWithdrawl = 1,
        autoPay = 2,
        checkWithdrawl = 3,
        wireWithdrawl = 4,
        autoDeposit = 5,
        checkDeposit = 6,
        wireDeposit = 7,
        fee = 8,
        outofrange
    }
}