using Univi.Shared;

namespace Univi.Client.Services.KindofReportService
{
    public interface IKindofreportService
    {

        List<KindOfReport> KindofReports { get; set; }
        Task GetKindofReports();
        Task<KindOfReport?> GetKindofReportsById(int id);
        Task CreateKindofReport(KindOfReport kindofreport);
        Task DeleteKindofReport(int id);
    }
}
