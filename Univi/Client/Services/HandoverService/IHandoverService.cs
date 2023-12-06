using Univi.Shared;

namespace Univi.Client.Services.HandoverService
{
    public interface IHandoverService
    {
        List<Handover> HandoversList { get; set; }
        Task GetHandovers();
        Task<Handover?> GetLatest5HandoversAsync();
        Task<Handover?> GetSingleHandover(int? id);
        Task AddHandoverAsync(Handover handover);
        Task SetItemInactive(int id);
        Task UpdateHandoverAsync(Handover handover);
    }
}
