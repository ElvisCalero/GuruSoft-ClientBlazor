// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace webPostgres.Pages.Products
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
    public partial class FormProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Products\FormProduct.razor"
       
    [Parameter] public Product Product { get; set; } = new();
    [Parameter] public String TextButton { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
