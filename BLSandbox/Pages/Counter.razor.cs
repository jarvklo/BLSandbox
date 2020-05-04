using BLSandbox.Data;
using Microsoft.AspNetCore.Components;

namespace BLSandbox.Pages
{
    public partial class Counter
    {
        [Inject] protected CounterService counterService { get; set; }
        private async void IncrementPersistentCount()
        {
            counterService.CounterValue++;
            await InvokeAsync(StateHasChanged);
        }

        protected override void OnInitialized()
        {
            var timer = new System.Threading.Timer((_) =>
            {
                InvokeAsync(() =>
                {

                    StateHasChanged();
                });
            }, null, 0, 1000);
            base.OnInitialized();
        }
    }
}
