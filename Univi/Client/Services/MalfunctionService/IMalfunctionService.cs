using Univi.Shared;

namespace Univi.Client.Services.MalfunctionService
{
    public interface IMalfunctionService
    {
        List<Malfunction> Malfunctions { get; set; }
        List<KindofMalfunction> KindofMalfunctions { get; set; }
        Task AddMalfunction(Malfunction malfunction);
        Task GetMalfunctions();
        Task<Malfunction?> GetSingleMalfunction(int id);
        Task<StatusCode?> GetStatusCodes();
        Task<KindofMalfunction?> GetKindofMalfunctions();


    }
}
