#pragma checksum "C:\Work\Sessions\BlazorDotNet5\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d81f89f6276bdec6cc0390f949be312170db659"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDotNet5.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Work\Sessions\BlazorDotNet5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Work\Sessions\BlazorDotNet5\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Work\Sessions\BlazorDotNet5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Work\Sessions\BlazorDotNet5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\Sessions\BlazorDotNet5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Work\Sessions\BlazorDotNet5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Work\Sessions\BlazorDotNet5\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Work\Sessions\BlazorDotNet5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Work\Sessions\BlazorDotNet5\_Imports.razor"
using BlazorDotNet5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Work\Sessions\BlazorDotNet5\_Imports.razor"
using BlazorDotNet5.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "root");
            __builder.AddAttribute(2, "b-i4o381lxyf");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "header");
            __builder.AddAttribute(5, "b-i4o381lxyf");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
            __builder.AddAttribute(7, "href", "");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "<span class=\"header-text\" b-i4o381lxyf>BLAZOR .NET 5.0 FTW!</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n  ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "nav");
            __builder.AddAttribute(13, "b-i4o381lxyf");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "href", "file");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(17, "<button b-i4o381lxyf>UPLOAD FILE</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n  ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "body");
            __builder.AddAttribute(21, "b-i4o381lxyf");
            __builder.AddContent(22, 
#nullable restore
#line 11 "C:\Work\Sessions\BlazorDotNet5\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
