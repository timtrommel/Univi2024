using System.Net;
using System.Net.Http.Json;
using Univi.Shared;

namespace Univi.Client.Services.HandoverService
{
    public class HandoverService : IHandoverService
    {
        #region CTOR
        private readonly HttpClient _http;

        public HandoverService(HttpClient http)
        {
            _http = http;
        }
        #endregion

        public List<Handover> HandoversList { get; set; }

        public async Task AddHandoverAsync(Handover handover)
        {
            await _http.PostAsJsonAsync($"/api/handover", handover);
        }

        public async Task GetHandovers()
        {
            var result = await _http.GetFromJsonAsync<List<Handover>>("api/handover");
            if (result != null)
            {
                HandoversList = result;
            }
        }

        public async Task<Handover?> GetLatest5HandoversAsync()
        {
            var handovers = await _http.GetAsync($"/api/Handover/Latest5");
            if (handovers.StatusCode == HttpStatusCode.OK)
            {
                return await handovers.Content.ReadFromJsonAsync<Handover>();
            }
            return null;
        }

        public async Task<Handover?> GetSingleHandover(int? id)
        {
            var handover = await _http.GetAsync($"/api/handover/{id}");
            if (handover.StatusCode == HttpStatusCode.OK)
            {
                return await handover.Content.ReadFromJsonAsync<Handover>();
            }
            return null;
        }

        public async Task SetItemInactive(int id)
        {
            // Send a POST request to update the item status
            await _http.PostAsJsonAsync($"api/handover/inactive", id);
        }

        public async Task UpdateHandoverAsync(Handover handover)
        {
            await _http.PutAsJsonAsync($"api/handover", handover);
        }



    }
}
