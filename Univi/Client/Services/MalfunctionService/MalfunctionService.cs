using System.Net.Http.Json;
using System.Net;
using Univi.Shared;

namespace Univi.Client.Services.MalfunctionService
{
    public class MalfunctionService : IMalfunctionService
    {
        private readonly HttpClient _http;

        public MalfunctionService(HttpClient http)
        {
            _http = http;
        }

        public List<Malfunction> Malfunctions { get; set; } = new();
        public List<KindofMalfunction> KindofMalfunctions { get; set; } = new();

        public async Task AddMalfunction(Malfunction malfunction)
        {
            await _http.PostAsJsonAsync($"/api/malfunction", malfunction);
        }

        public async Task<KindofMalfunction?> GetKindofMalfunctions()
        {
            var result = await _http.GetFromJsonAsync<List<KindofMalfunction>>("api/KindofMalfunction");
            if (result != null)
            {
                KindofMalfunctions = result;
            }
            return null;

        }

        public async Task<Malfunction?> GetLatest5Malfunctions()
        {
            var latest5 = await _http.GetAsync($"/api/malfunction/");
            if (latest5.StatusCode == HttpStatusCode.OK)
            {
                return await latest5.Content.ReadFromJsonAsync<Malfunction>();
            }
            return null;
        }

        public async Task GetMalfunctions()
        {
            var malfunctions = await _http.GetFromJsonAsync<List<Malfunction>>("api/Malfunction");
            if (malfunctions != null)
            {
                Malfunctions = malfunctions;
            }

        }

        public async Task<Malfunction?> GetSingleMalfunction(int id)
        {
            var malfunction = await _http.GetAsync($"/api/malfunction/{id}");
            if (malfunction.StatusCode == HttpStatusCode.OK)
            {
                return await malfunction.Content.ReadFromJsonAsync<Malfunction>();
            }
            return null;
        }

        public async Task<StatusCode?> GetStatusCodes()
        {
            var status = await _http.GetAsync($"/api/malfunction/StatusCode");
            if (status.StatusCode == HttpStatusCode.OK)
            {
                return await status.Content.ReadFromJsonAsync<StatusCode>();
            }
            return null;
        }
    }
}
