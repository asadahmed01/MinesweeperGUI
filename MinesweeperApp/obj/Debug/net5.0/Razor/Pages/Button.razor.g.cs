#pragma checksum "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Button.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d0c1b828d0c8c58d9fb3c2994ccc0cea8a6e333"
// <auto-generated/>
#pragma warning disable 1591
namespace MinesweeperApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\_Imports.razor"
using MinesweeperApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\_Imports.razor"
using MinesweeperApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class Button : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "type", "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Button.razor"
                                OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-x4jo15ojz0");
            __builder.AddContent(4, 
#nullable restore
#line 1 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Button.razor"
                                                  Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Button.razor"
       
    [Parameter]
  public string Content { get; set; }

 [Parameter]
 public EventCallback<MouseEventArgs>OnClickCallback { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
