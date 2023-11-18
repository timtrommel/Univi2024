using System.Net.Http.Json;
using Univi.Shared;

namespace Univi.Client.Services.BuildingService
{
    public class BuildingService : IBuildingService
    {
        private readonly HttpClient _http;

        public BuildingService(HttpClient http)
        {
            _http = http;
        }

        //
        public List<Building> Buildings { get; set; } = new List<Building>();

        public async Task GetBuildings()
        {
            var result = await _http.GetFromJsonAsync<List<Building>>("api/building");
            if (result != null)
                Buildings = result;
        }
    }
}
