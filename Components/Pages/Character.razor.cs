using Microsoft.AspNetCore.Components;

namespace AzurLaneLoreWiki.Components.Pages
{
    public partial class Character
    {
        [Parameter]
        public string Name { get; set; } = "";

    }
}