using System.Net.Http.Json;
using System.Net;
using Univi.Shared;

namespace Univi.Client.Services.KindofReportService
{
    public class KindofreportService : IKindofreportService
    {
        private readonly HttpClient _http;

        public KindofreportService(HttpClient http)
        {
            _http = http;
        }

        public List<KindOfReport> KindofReports { get; set; } = new();

        public Task CreateKindofReport(KindOfReport kindofreport)
        {
            throw new NotImplementedException();
        }

        public Task DeleteKindofReport(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetKindofReports()
        {
            var result = await _http.GetFromJsonAsync<List<KindOfReport>>("api/report/kindofreport");
            if (result != null)
            {
                KindofReports = result;
            }
        }

        public async Task<KindOfReport?> GetKindofReportsById(int id)
        {
            var result = await _http.GetAsync($"api/KindofReport/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<KindOfReport>();
            }
            return null;
        }
    }
}
