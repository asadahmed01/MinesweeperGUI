#pragma checksum "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef2d62b42fe942805bafc151035e91999a2596a"
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
#nullable restore
#line 2 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Index.razor"
using MinesweeperApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 b-uz0pier1fu>Hello, Welcome To The Game.</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "class", "text-danger");
            __builder.AddAttribute(3, "b-uz0pier1fu");
            __builder.AddContent(4, 
#nullable restore
#line 8 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Index.razor"
                        minutes.ToString("00")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " : ");
            __builder.AddContent(6, 
#nullable restore
#line 8 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Index.razor"
                                                  seconds.ToString("00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "outter");
            __builder.AddAttribute(10, "b-uz0pier1fu");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "inner");
            __builder.AddAttribute(13, "b-uz0pier1fu");
#nullable restore
#line 12 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Index.razor"
     foreach(var item in cells)
    {
        if(item.Visited)
        {
             if (item.IsLive)
            {
                    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<button class=\"bomb\" b-uz0pier1fu>💣</button>");
#nullable restore
#line 20 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Index.razor"
            }

            else if (item.NumberOfNeighborsLve > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "uncleared");
            __builder.AddAttribute(17, "b-uz0pier1fu");
            __builder.AddContent(18, 
#nullable restore
#line 24 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Index.razor"
                                           item.NumberOfNeighborsLve

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Index.razor"
                    
            }

            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<button class=\"cleared\" b-uz0pier1fu></button>");
#nullable restore
#line 31 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Index.razor"
            }   
        }

        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "uncleared");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Index.razor"
                                                (() => Name(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "b-uz0pier1fu");
            __builder.AddContent(24, "?");
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\asada\Desktop\C#\MinesweeperApp\MinesweeperApp\Pages\Index.razor"
        }
          
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
