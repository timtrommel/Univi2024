using Microsoft.AspNetCore.Components;
using Univi.Client.Services.KindofMalfunctionService;
using Univi.Client.Services.MalfunctionService;

namespace Univi.Client.Pages.Dashboard.Components
{
    public class MalfunctionComponentBase : ComponentBase
    {
        [Inject]
        protected IMalfunctionService? MalfunctionService { get; set; }
        [Inject]
        protected IKindofMalfunctionService? KindofMalfunctionService { get; set; }


        protected override async Task OnInitializedAsync()
        {
            if(MalfunctionService != null)
            {
                await MalfunctionService.GetMalfunctions();
            }
            if(KindofMalfunctionService != null)
            {
                await KindofMalfunctionService.GetKindofMalfunctions();
            }
        }


    }
}
