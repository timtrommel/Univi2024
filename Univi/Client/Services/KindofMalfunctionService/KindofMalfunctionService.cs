using System.Net.Http.Json;
using System.Net;
using Univi.Shared;

namespace Univi.Client.Services.KindofMalfunctionService
{
    public class KindofMalfunctionService : IKindofMalfunctionService
    {
        private readonly HttpClient _http;

        public KindofMalfunctionService(HttpClient http)
        {
            _http = http;
        }

        public List<KindofMalfunction> KindofMalfunctions { get; set; } = new();

        public Task CreateKindofMalfunctiont(KindofMalfunction kindofmalfunction)
        {
            throw new NotImplementedException();
        }

        public Task DeleteKindofmalfunction(int id)
        {
            throw new NotImplementedException();
        }

        public Task<KindofMalfunction?> GetKindofMalfunctionById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetKindofMalfunctions()
        {
            var result = await  _http.GetFromJsonAsync<List<KindofMalfunction>>("/api/Malfunction/kindofmalfunctions");
            if (result != null)
            {
                KindofMalfunctions = result;
            }
        }
    }
}
