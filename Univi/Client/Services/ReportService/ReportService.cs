using System.Net.Http.Json;
using System.Net;
using Univi.Shared;

namespace Univi.Client.Services.ReportService
{
    public class ReportService : IReportService
    {
        #region props
        private readonly HttpClient _http;
        #endregion

        #region CTOR
        public ReportService(HttpClient http)
        {
            _http = http;
        }
        #endregion

        public List<Report> Reports { get; set; } = new();
        public List<Report> ReportNo { get; set; } = new();

        public async Task CreateReport(Report report)
        {
            await _http.PostAsJsonAsync("api/report/", report);
        }

        public Task DeleteReport(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Report?> GetReportById(string id)
        {
            var result = await _http.GetAsync($"api/report/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<Report>();
            }
            return null;
        }

        public async Task GetReports()
        {
            var result = await _http.GetFromJsonAsync<List<Report>>("api/report");
            if (result != null)
            {
                Reports = result;
            }

        }

        public async Task UpdateReport(Report report)
        {
            await _http.PutAsJsonAsync($"api/report", report);
        }
    }
}
