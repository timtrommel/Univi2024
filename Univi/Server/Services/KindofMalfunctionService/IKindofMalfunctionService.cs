using Univi.Shared;

namespace Univi.Server.Services.KindofMalfunctionService
{
    public interface IKindofMalfunctionService
    {
        Task<List<KindofMalfunction>> GetKindofMalfunctions();
        Task<KindofMalfunction> CreateKindofMalfunction(KindofMalfunction kindofMalfunction);
    }
}
