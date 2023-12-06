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
        [Inject]
        NavigationManager? Navigation { get; set; }

        protected bool NoStartEnd { get; set; } = true;

        //Create instance of handover
        protected Handover handover = new()
        {
            DateCreated = DateTime.Now,
            StartDate = DateTime.Now,
            EndDate = DateTime.Now,
            StartTime = DateTime.Now,
            EndTime = DateTime.Now,
            DateHandover = DateTime.Now,
            DateLastEdit = DateTime.Now,
        };

        //Send the form
        protected async Task HandleSubmit()
        {
            if (handoverService != null) // Create a new handover
            {
                await handoverService.AddHandoverAsync(handover);
                Navigation?.NavigateTo("/");
            }
        }
    }
}
