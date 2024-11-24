using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Projections.TruDat.TruBiz;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface ITruDatTruBizCrud : IQaLibCrud
{
    Task<ReturnValue<TruDatTruBizPetPolicyProjection>> RetrieveTruBizPetPolicyProjectionByPetIdAsync(int petId, TruDatTruBizContext? context = null);
}