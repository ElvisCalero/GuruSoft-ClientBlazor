#pragma checksum "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cc3440d948caf884cc4c21569af07c2f48f0ed9"
// <auto-generated/>
#pragma warning disable 1591
namespace webPostgres.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using webPostgres;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using webPostgres.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using webPostgres.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Deportive Shop</h1>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
