using Microsoft.AspNetCore.Components;
using Univi.Client.Services.HandoverService;
using Univi.Client.Services.KindofReportService;
using Univi.Shared;

namespace Univi.Client.Pages.Handovers
{
    public class CreateHandoverBase : ComponentBase
    {
        [Inject]
        protected IHandoverService? handoverService { get; set; }
        [Inject]
        protected IKindofreportService? kindofReportService { get; set; }

        //Create instance of handover
        protected Handover handover = new()
        {
            DateCreated = DateTime.Now,
            DateHandover = DateTime.Now,
            DateLastEdit = DateTime.Now,
            Title = "",
            AddedById = "",
            KindofHandoverId = 1,
            BuildingId = 1,
            Description = "",
        };

        protected async void CreateHandover()
        {
            if (handoverService != null && handover != null)
            {
                await handoverService.AddHandoverAsync(handover);
            }
            if(kindofReportService != null)
            {
                await kindofReportService.GetKindofReports();
            }

        }
    }
}
