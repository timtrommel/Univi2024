using System.Net.Http.Json;
using System.Net;
using Univi.Shared;

namespace Univi.Client.Services.KeyService
{
    public class KeyService : IKeyService
    {
        private readonly HttpClient _http;


        public KeyService(HttpClient http)
        {
            _http = http;
        }

        public List<KeyList> keylist { get; set; } = new();
        public List<KeyIssue> issue { get; set; } = new();
        public List<KeyList> ActiveKeys { get; set; } = new();

        public Task AddKeyIssue(KeyIssue key)
        {
            throw new NotImplementedException();
        }

        public async Task GetKeyIssues()
        {
            var result = await _http.GetFromJsonAsync<List<KeyIssue>>("api/Key");
            if (result != null)
            {
                issue = result;
            }
        }

        public Task<KeyList?> GetKeyListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<KeyIssue?> GetLatest5KeyIssues()
        {
            throw new NotImplementedException();
        }

        public Task<KeyList?> GetReturnedKeysAsync()
        {
            throw new NotImplementedException();
        }

        public Task SetKeyOnReturned(string id)
        {
            throw new NotImplementedException();
        }
    }
}
