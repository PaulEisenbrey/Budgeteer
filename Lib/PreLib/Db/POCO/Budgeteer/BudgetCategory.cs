using System;
using System.Collections.Generic;

namespace Database.POCO.Budgeteer;

public partial class BudgetCategory
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;
}
