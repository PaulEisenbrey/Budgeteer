namespace Database.Trupanion.Entity.TestData.Dbo;

public  class TestDataDboGetWaitingPeriod
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public int AccidentWaitingPeriod { get; set; }
    public int IllnessWaitingPeriod { get; set; }
}
