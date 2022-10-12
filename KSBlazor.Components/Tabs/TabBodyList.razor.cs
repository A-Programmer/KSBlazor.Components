using Microsoft.AspNetCore.Components;

namespace KSBlazor.Components
{
    partial class TabBodyList
    {
        [Parameter]
        public string Identifier { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
