using Database.Trupanion.Projections.TruDat.Dbo;
using Database.Trupanion.Projections.TruDat.TruBiz;

namespace Database.Trupanion.Entity.Aggregates;

public class OwnerCollection
{
    public int OwnerId => this.Owner?.Id ?? 0;

    public TruDatDboOwnerProjection? Owner { get; private set; }

    public TruDatDboOwnerAddressProjection? Address { get; private set; }

    public List<PetAndPolicy> PetAndPolicies { get; private set; } = new List<PetAndPolicy>();

    public TruDatDboPetProjection? GetPet(string petName) => this.PetAndPolicies.FirstOrDefault
            (
                x => x.Pet.Name.Equals
                (
                    petName,
                    StringComparison.CurrentCultureIgnoreCase
                )
            )?.Pet ?? null;

    public List<TruDatDboPetProjection> Pets => this.PetAndPolicies.Select(pp => pp.Pet).ToList();

    public List<TruDatTruBizPetPolicyProjection> PetPolicies => this.PetAndPolicies.Select(pp => pp.PetPolicy).ToList();

    public List<TruDatDboPetPolicyProjection> DboPetPolicies => this.PetAndPolicies.Select(pp => pp.DboPetPolicy).ToList();

    public TruDatDboPetProjection? GetPet(int petId) => this.PetAndPolicies.FirstOrDefault(x => x.Pet.Id == petId)?.Pet ?? null;

    public TruDatTruBizPetPolicyProjection? GetPetPolicy(string petName) => this.PetAndPolicies.FirstOrDefault
            (
                x => x.Pet.Name.Equals
                (
                    petName,
                    StringComparison.CurrentCultureIgnoreCase
                )
            )?.PetPolicy ?? null;

    public TruDatDboPetPolicyProjection? GetDboPetPolicy(string petName) => this.PetAndPolicies.FirstOrDefault
            (
                x => x.Pet.Name.Equals
                (
                    petName,
                    StringComparison.CurrentCultureIgnoreCase
                )
            )?.DboPetPolicy ?? null;

    public TruDatTruBizPetPolicyProjection? GetPolicy(int petId) => this.PetAndPolicies.FirstOrDefault(x => x.Pet.Id == petId)?.PetPolicy ?? null;

    public OwnerCollection SetOwner(TruDatDboOwnerProjection owner)
    {
        this.Owner = owner;
        return this;
    }

    public OwnerCollection SetAddress(TruDatDboOwnerAddressProjection address)
    {
        this.Address = address;
        return this;
    }

    public OwnerCollection AddPetAndPolicy(PetAndPolicy petAndPolicy)
    {
        this.PetAndPolicies.Add(petAndPolicy);
        return this;
    }

    public OwnerCollection AddPetAndPolicies(IEnumerable<PetAndPolicy> petAndPolicies)
    {
        this.PetAndPolicies.AddRange(petAndPolicies);
        return this;
    }
}