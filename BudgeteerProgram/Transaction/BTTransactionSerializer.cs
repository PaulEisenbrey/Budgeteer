using Budgeteer.Constants;

namespace Budgeteer.Transaction
{
    public class BTTransactionSerializer : BTTransaction
    {
        public new Guid TransactionId
        {
            get => this.transactionId;
            set
            {
                if (this.transactionId == Guid.Empty)
                {
                    this.transactionId = value;
                }
            }
        }

        public new DateTime TransactionDate
        {
            get => this.transactionDate;
            set
            {
                if (this.transactionDate == DateTime.MinValue)
                {
                    this.transactionDate = value;
                }
            }
        }

        public new TransactionType PaymentType
        {
            get => this.paymentType;
            set
            {
                if (this.paymentType == TransactionType.unintialized)
                {
                    this.paymentType = value;
                }
            }
        }

        public new decimal TransactionAmount
        {
            get => this.transactionAmount;
            set
            {
                if (this.transactionAmount == 0.0m)
                {
                    this.transactionAmount = value;
                }
            }
        }

        public new int SourceId
        {
            get => this.sourceId;
            set
            {
                if (this.sourceId == 0)
                {
                    this.sourceId = value;
                }
            }
        }
    }
}
