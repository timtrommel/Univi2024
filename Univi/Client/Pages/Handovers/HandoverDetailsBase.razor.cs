using Microsoft.AspNetCore.Components;
using Univi.Client.Services.HandoverService;
using Univi.Shared;


namespace Univi.Client.Pages.Handovers
{
    public class HandoverDetailsBase : ComponentBase
    {
        [Inject]
        protected IHandoverService? HandoverService { get; set; }
        [Inject]
        protected NavigationManager? Navigation { get; set; }

        protected Handover handover = new()
        {
            DateCreated = DateTime.Now,
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(1),
            StartTime = DateTime.Now,
            EndTime = DateTime.Now.AddHours(8),
            NoStartEnd = true
        };

        [Parameter]
        public int? Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            if (Id != null)
            {
                if (HandoverService != null)
                {
                    var result = await HandoverService.GetSingleHandover(Id);
                    if (result != null)
                    {
                        //Check if there is no startDate filled in and set the date from today.
                        if (result.NoStartEnd == true)
                        {
                            result.StartDate = DateTime.Now;
                            result.EndDate = DateTime.Now;
                        }
                        handover = result;
                    }
                    else
                    {
                        Navigation?.NavigateTo("/CreateHandover");

                    }
                }

            }
        }

        protected override async Task OnInitializedAsync()
        {
            if (HandoverService != null)
            {
                await HandoverService.GetHandovers();
            }
        }


    }
}
