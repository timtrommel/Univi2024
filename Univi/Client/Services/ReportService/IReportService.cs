using Univi.Shared;

namespace Univi.Client.Services.ReportService
{
    public interface IReportService
    {
        List<Report> Reports { get; set; }
        Task GetReports();
        Task<Report?> GetReportById(string id);
        Task CreateReport(Report report);
        Task UpdateReport(Report report);
        Task DeleteReport(string id);
    }
}
