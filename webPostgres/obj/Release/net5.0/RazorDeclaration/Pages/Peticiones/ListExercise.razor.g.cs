// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace webPostgres.Pages.Peticiones
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Exercises")]
    public partial class ListExercise : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
       
    Peticion[] exercises { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await GetExercises();
    }
    async Task GetExercises()
    {
        exercises = await Http.GetFromJsonAsync<Peticion[]>("https://localhost:44392/api/Peticion");
    }
    async Task DeleteAsync(int Id)
    {
        await Http.DeleteAsync($"https://localhost:44392/api/Peticion/{Id}");
        await GetExercises();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
