using Univi.Shared;

namespace Univi.Client.Services.KindofMalfunctionService
{
    public interface IKindofMalfunctionService
    {
        List<KindofMalfunction> KindofMalfunctions { get; set; }
        Task GetKindofMalfunctions();
        Task<KindofMalfunction?> GetKindofMalfunctionById(int id);
        Task CreateKindofMalfunctiont(KindofMalfunction kindofmalfunction);
        Task DeleteKindofmalfunction(int id);
    }
}
