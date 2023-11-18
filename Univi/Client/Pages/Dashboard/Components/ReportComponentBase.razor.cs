using Microsoft.AspNetCore.Components;
using Univi.Client.Services.BuildingService;
using Univi.Client.Services.KindofReportService;
using Univi.Client.Services.ReportService;

namespace Univi.Client.Pages.Dashboard.Components
{
    public class ReportComponentBase: ComponentBase
    {
        [Inject]
        protected IReportService? ReportService { get; set; }
        [Inject]
        protected IBuildingService? BuildingService { get; set; }
        [Inject]
        protected IKindofreportService? KindofReportService { get; set; }


        protected override async Task OnInitializedAsync()
        {
            //If the service is not null, then load a list of reports
            if (ReportService != null)
            {
                await ReportService.GetReports();
            }
            if(BuildingService != null)
            {
                await BuildingService.GetBuildings();
            }
            if(KindofReportService != null)
            {
                await KindofReportService.GetKindofReports();
            }
        }
    }
}
