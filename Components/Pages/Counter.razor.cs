using Microsoft.AspNetCore.Components;

namespace AzurLaneLoreWiki.Components.Pages
{
    public partial class Counter
    {
        [Parameter]
        public int Start { get; set; }
        //private int currentCount = 0;

        private void IncrementCount()
        {
            Start++;
        }
    }
}