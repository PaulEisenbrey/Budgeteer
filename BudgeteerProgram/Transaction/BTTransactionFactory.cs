using Budgeteer.Constants;

namespace Budgeteer.Transaction
{
    public sealed class BTTransactionFactory : BTTransaction, IBTTransactionFactory
    {
        public BTTransaction CreateTransaction(decimal transactionAmount, TransactionType paymentType, int sourceId = 0) =>
            base.CreateTransactionImplementation(transactionAmount, paymentType, sourceId);
    }
}
