#pragma checksum "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f83d55de676ca4d2db567e759733b6dd16efed02"
// <auto-generated/>
#pragma warning disable 1591
namespace LatihanBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\_Imports.razor"
using LatihanBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\_Imports.razor"
using LatihanBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<LatihanBlazor.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<LatihanBlazor.Pages.Counter>(4);
            __builder.AddAttribute(5, "IncrementAmount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\Pages\Index.razor"
                          2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<LatihanBlazor.Pages.Counter>(7);
            __builder.AddAttribute(8, "IncrementAmount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\Semester 5\Pemrograman Front End\Project\LatihanBlazor\Pages\Index.razor"
                          4

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
