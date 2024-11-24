namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore
{
    public partial class VmPLCPolicyTermAddOnProductCoverOption
    {
        public int Id { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Limit { get; set; }
        public decimal? CoInsurance { get; set; }
        public decimal? Excess { get; set; }
        public int ProductCoverOptionsId { get; set; }
        public decimal DiscountedPeriodicalPremium { get; set; }
        public int PetPolicyId { get; set; }
        public int CustomerId { get; set; }

        public virtual List<VmPLCPolicyTermPolicyTermAddOn> PolicyTermPolicyTermAddOns { get; set; } = new();
    }
}
