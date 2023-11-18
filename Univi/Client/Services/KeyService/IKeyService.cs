using Univi.Shared;

namespace Univi.Client.Services.KeyService
{
    public interface IKeyService
    {
        List<KeyList> keylist { get; set; }
        List<KeyList> ActiveKeys { get; set; }
        List<KeyIssue> issue { get; set; }
        Task GetKeyIssues();
        Task<KeyIssue?> GetLatest5KeyIssues();
        Task<KeyList?> GetKeyListAsync();
        Task<KeyList?> GetReturnedKeysAsync();
        Task AddKeyIssue(KeyIssue key);
        Task SetKeyOnReturned(string id);
    }
}
