using Univi.Shared;

namespace Univi.Server.Services.HandoverService
{
    public interface IHandoverService
    {
        Task<List<Handover>> GetHandovers();
    }
}
