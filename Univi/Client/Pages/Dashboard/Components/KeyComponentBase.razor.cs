using Microsoft.AspNetCore.Components;
using Univi.Client.Services.KeyService;

namespace Univi.Client.Pages.Dashboard.Components
{
    public class KeyComponentBase:ComponentBase
    {
        [Inject]
        protected IKeyService? Keyservice { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if(Keyservice != null)
            {
                await Keyservice.GetKeyIssues();
            }
        }
    }
}
