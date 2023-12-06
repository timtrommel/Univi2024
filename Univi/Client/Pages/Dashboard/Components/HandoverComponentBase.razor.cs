using Microsoft.AspNetCore.Components;
using Univi.Client.Services.HandoverService;
using Univi.Client.Services.KindofReportService;

namespace Univi.Client.Pages.Dashboard.Components
{
    public class HandoverComponentBase : ComponentBase
    {
        [Inject]
        protected IHandoverService? HandoverService { get; set; }
        [Inject]
        protected IKindofreportService? KindofReportService { get; set; }
        [Inject]
        protected NavigationManager? Navigation { get; set; }
       

        protected override async Task OnInitializedAsync()
        {
            if (HandoverService != null)
            {
                await HandoverService.GetHandovers();
            }
            if (KindofReportService != null)
            {
                await KindofReportService.GetKindofReports();
            }
        }

        protected void GetReport(int id)
        {
            if(HandoverService != null)
            {
                Navigation.NavigateTo($"/Handoverdetails/{id}");
            }
        } 

    }
}
