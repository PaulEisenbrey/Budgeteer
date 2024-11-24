using Budgeteer.Constants;

namespace Budgeteer.Transaction
{
    internal interface IBTTransactionFactory
    {
        BTTransaction CreateTransaction(decimal transactionAmount, TransactionType paymentType, int sourceId = 0);
    }
}