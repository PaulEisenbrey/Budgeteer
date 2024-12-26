using System;
using System.Collections.Generic;

namespace Database.POCO.Budgeteer;

public partial class Transaction
{
    public int Id { get; set; }

    public Guid TransactionId { get; set; }

    public int AccountDatumId { get; set; }

    public DateTime TransactionDate { get; set; }

    public decimal TransactionAmount { get; set; }

    public int SourceId { get; set; }

    public string? Description { get; set; }

    public string? CheckNumber { get; set; }

    public int TransactionTypeId { get; set; }

    public int BudgetCategoryId { get; set; }

    public bool IsDeposit { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual AccountDatum AccountDatum { get; set; } = null!;

    public virtual TransactionType TransactionType { get; set; } = null!;
}
