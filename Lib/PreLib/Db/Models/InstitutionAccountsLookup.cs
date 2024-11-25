using Utilities.EntityBaseClasses;

namespace Database.Models;

public partial class InstitutionAccountsLookup : EntityIntId
{
    public int InstitutionId { get; set; }

    public int AccountDataId { get; set; }

    public virtual AccountDatum AccountData { get; set; } = new();

    public virtual Institution Institution { get; set; } = new();
}
