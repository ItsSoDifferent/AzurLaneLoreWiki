using Microsoft.AspNetCore.Components;

namespace AzurLaneLoreWiki.Components.Pages
{
    public partial class Event
    {
        [Parameter]
        public string Name { get; set; } = "";

    }
}