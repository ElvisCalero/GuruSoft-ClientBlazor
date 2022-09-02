#pragma checksum "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b9d6ddc5075f42cda5c9e5cc741281af52495a8"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>List Exercises</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"mb-3\"><a class=\"btn btn-success\" href=\"CreateExercise\">Create Exercise</a></div>");
#nullable restore
#line 8 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
 if (exercises == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
}
else if (exercises.Length == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "Data not found");
#nullable restore
#line 14 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
                               
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, @"<thead><tr><th></th>
                <th>Id</th>
                <th>Request</th>
                <th>Fecha Request</th>
                <th>Response</th>
                <th>Fecha Response</th>
                <th>Username</th></tr></thead>
        ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 31 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
             foreach (var item in exercises)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "class", "btn btn-success");
            __builder.AddAttribute(12, "href", "UpdateExercise/" + (
#nullable restore
#line 35 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
                                                                         item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-danger");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
                                                                 () => DeleteAsync(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 38 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
                         item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 39 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
                         item.Request

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 40 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
                         item.Fecha_Request

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 41 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
                         item.Response

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 42 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
                         item.Fecha_Response

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 43 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
                         item.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\59399\source\repos\ElvisCalero\IntiSoluciones-webPostgres\webPostgres\Pages\Peticiones\ListExercise.razor"
}

#line default
#line hidden
#nullable disable
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