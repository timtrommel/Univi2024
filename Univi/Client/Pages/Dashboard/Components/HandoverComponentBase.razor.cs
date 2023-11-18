using Microsoft.AspNetCore.Components;
using Univi.Client.Services.HandoverService;

namespace Univi.Client.Pages.Dashboard.Components
{
    public class HandoverComponentBase : ComponentBase
    {
        [Inject]
        protected IHandoverService? HandoverService { get; set; }


        protected override async Task OnInitializedAsync()
        {
            if (HandoverService != null)
            {
                await HandoverService.GetHandovers();
            }
        }
    }
}
