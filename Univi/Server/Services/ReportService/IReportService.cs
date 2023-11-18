using Univi.Shared;

namespace Univi.Server.Services.ReportService
{
    public interface IReportService
    {
        Task<List<Report>> GetReports();
        Task<Report?> GetReportById(int id);
        Task<Report?> CreateReport(Report report);
        Task<Report?> UpdateReport(Report report);
    }
}
