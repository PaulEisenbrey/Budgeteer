
using Database.Trupanion.Projections.TruDat.Dbo;
using Database.Trupanion.Projections.TruDat.TruBiz;

namespace Database.Trupanion.Entity.Aggregates;

public class PetAndPolicy
{
    private bool isBreedingFemale = false;
    public PetAndPolicy()
    {
    }

    public TruDatDboPetProjection Pet { get; private set; } = new();

    public TruDatTruBizPetPolicyProjection PetPolicy { get; private set; } = new();

    public TruDatDboPetPolicyProjection DboPetPolicy { get; private set; } = new();

    public bool IsSpayed { get; private set; } = false;

    public bool RecoveryAndComplementaryCardRider { get; private set; }

    public bool PetOwnerAssistanceRider { get; private set; }

    public List<int> WorkingPetId { get; private set; } = new();

    public bool IsBreedingFemale => this.Pet.Gender.ToLower() == "m" ? false : this.IsSpayed ? false : this.isBreedingFemale;

    public int? PetFoodId { get; private set; }

    public decimal Deductible { get; private set; }

    public PetAndPolicy SetPet(TruDatDboPetProjection pet)
    {
        this.Pet = pet;
        return this;
    }

    public PetAndPolicy SetPetPolicy(TruDatTruBizPetPolicyProjection petPolicy)
    {
        this.PetPolicy = petPolicy;
        return this;
    }

    public PetAndPolicy SetDboPetPolicy(TruDatDboPetPolicyProjection petPolicy)
    {
        this.DboPetPolicy = petPolicy;
        return this;
    }

    public PetAndPolicy SetSpayFlag(bool isSpayed)
    {
        this.IsSpayed = isSpayed;
        return this;
    }

    public PetAndPolicy SetBreedingFemaleFlag(bool isBreeding)
    {
        this.isBreedingFemale = isBreeding;
        return this;
    }

    public PetAndPolicy SetRACC(bool hasRACC)
    {
        this.RecoveryAndComplementaryCardRider = hasRACC;
        return this;
    }

    public PetAndPolicy SetPOAR(bool hasPOAR)
    {
        this.PetOwnerAssistanceRider = hasPOAR;
        return this;
    }

    public PetAndPolicy AddWorkingPetId(int id)
    {
        this.WorkingPetId.Add(id);
        return this;
    }

    public PetAndPolicy AddAllWorkingPetIds(IEnumerable<int> ids)
    {
        this.WorkingPetId.AddRange(ids);
        return this;
    }

    public PetAndPolicy SetDeductible(decimal deductible)
    {
        this.Deductible = deductible;
        return this;
    }
}
