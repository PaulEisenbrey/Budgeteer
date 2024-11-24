using Budgeteer.Constants;

namespace Budgeteer.Transaction
{
    public class BTTransaction : BTTransactionData
    {
        public Guid TransactionId
        {
            get => transactionId;
            set => transactionId = value;
        }

        public DateTime TransactionDate
        {
            get => transactionDate;
            set => transactionDate = value;
        }

        public TransactionType PaymentType
        {
            get => paymentType;
            set => paymentType = value;
        }

        public decimal TransactionAmount
        {
            get => transactionAmount;
            set => transactionAmount = value;
        }

        public int SourceId
        {
            get => sourceId;
            set => sourceId = value;
        }

        public int CheckNumber
        {
            get => checkNumber;
            set => checkNumber = value;
        }

        protected BTTransaction CreateTransactionImplementation(decimal transactionAmount, TransactionType paymentType, int sourceId, int checkNumber = 0)
        {
            return new BTTransaction
            {
                transactionId = Guid.NewGuid(),
                transactionDate = DateTime.UtcNow,
                paymentType = paymentType,
                transactionAmount = transactionAmount,
                sourceId = sourceId,
                checkNumber = checkNumber
            };
        }
    }
}
