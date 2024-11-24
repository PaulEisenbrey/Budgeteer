using Budgeteer.Constants;

namespace Budgeteer.Transaction
{
    public class BTTransactionData
    {
        protected Guid transactionId = Guid.Empty;
        protected DateTime transactionDate = DateTime.MinValue;
        protected TransactionType paymentType = TransactionType.unintialized;
        protected decimal transactionAmount = 0.0m;
        protected int checkNumber = 0;
        protected int sourceId = 0;
    }
}
