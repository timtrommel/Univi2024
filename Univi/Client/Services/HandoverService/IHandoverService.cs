using Univi.Shared;

namespace Univi.Client.Services.HandoverService
{
    public interface IHandoverService
    {
        List<Handover> Handovers { get; set; }
        Task GetHandovers();
        Task<Handover?> GetLatest5HandoversAsync();
        Task<Handover?> GetSingleHandovers(string id);
        Task AddHandoverAsync(Handover handover);
        Task SetItemInactive(string id);
        Task UpdateHandoverAsync(Handover handover);
    }
}
