using Univi.Shared;

namespace Univi.Server.Services.KindofReportService
{
    public interface IKindofReportService
    {
        Task<List<KindOfReport>> GetKindofReports();
        Task<KindOfReport?> GetKindofReporttById(int id);
        Task<KindOfReport?> CreateKindofReport(KindOfReport kindofreport);
    }
}
