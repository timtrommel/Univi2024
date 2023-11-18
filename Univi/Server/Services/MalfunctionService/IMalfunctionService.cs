using Univi.Shared;

namespace Univi.Server.Services.MalfunctionService
{
    public interface IMalfunctionService
    {
        Task<List<KindofMalfunction>> GetKindofMalfunctions();
        Task<List<Malfunction>> GetMalfunctions();
        Task<Malfunction> CreateMalfunction(Malfunction malfunction);
    }
}
