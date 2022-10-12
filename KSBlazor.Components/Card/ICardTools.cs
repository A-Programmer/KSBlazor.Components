using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace KSBlazor.Components
{
    public interface ICardTools
    {
        bool IsMaximized { get; }
        EventCallback<System.Tuple<ICardTools, MouseEventArgs>> OnRefresh { get; set; }
        CardToolOptions ToolOptions { get; set; }
        RenderFragment CustomTools { get; }
    }
}