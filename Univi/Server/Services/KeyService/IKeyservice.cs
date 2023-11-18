using Univi.Shared;

namespace Univi.Server.Services.KeyService
{
    public interface IKeyservice
    {
        Task<List<KeyIssue>> GetKeyIssues();
        Task<List<KeyList>> GetKeyList();
        Task<List<KeyList>> GetReturnedKeys();
        Task<KeyIssue?> GetKeyissueById(string id);
        Task<KeyIssue?> CreateKeyIssue(KeyIssue keyissue);
        Task<KeyIssue?> SetKeyReturned(string id);
    }
}
