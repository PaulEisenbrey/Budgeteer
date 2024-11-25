using System;
using System.Collections.Generic;
using Utilities.EntityBaseClasses;

namespace Database.Models;

public partial class TransactionType : EntityIntId
{
    public string Description { get; set; } = string.Empty;

    public virtual List<Transaction> Transactions { get; set; } = new();
}
