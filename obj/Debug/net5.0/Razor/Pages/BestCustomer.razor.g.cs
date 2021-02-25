#pragma checksum "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f211133df7191e830ed3b4cd61ff3f6903b09acf"
// <auto-generated/>
#pragma warning disable 1591
namespace Querys.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Querys;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Querys.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/alejandro/Itla/C5/prog_3/tarea_5/_Imports.razor"
using Querys.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomer.razor"
using Querys.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/best-customer")]
    public partial class BestCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Mejor Cliente</h3>");
#nullable restore
#line 7 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomer.razor"
 if (customer == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Querys.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "Suplidores no encontrados");
            __builder.CloseComponent();
#nullable restore
#line 10 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomer.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Querys.Components.List>(3);
            __builder.AddAttribute(4, "Bold", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, 
#nullable restore
#line 14 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomer.razor"
               customer.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(6, " ");
                __builder2.AddContent(7, 
#nullable restore
#line 14 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomer.razor"
                            customer.FirstName

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(8, "Thin", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, 
#nullable restore
#line 15 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomer.razor"
               customer.Bought

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 17 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomer.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomer.razor"
       

        BestCustomers customer;

        protected override void OnInitialized()
    {
        base.OnInitialized();
        GetCustomer();
    }

    void GetCustomer()
    {
        var query = from c in context.Customers
                    join o in context.Orders on c.Id equals o.CustomerId
                    join od in context.OrderDetails on o.Id equals od.OrderId
                    group od by new { c.Id, c.Company, c.FirstName, c.LastName } into g
                    select new BestCustomers
                    {
                        Id = g.Key.Id,
                        Company = g.Key.Company,
                        FirstName = g.Key.FirstName,
                        LastName = g.Key.LastName,
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomer.razor"
                                                            
                        OrdersQty = g.Count(),
                        Bought = Math.Round(g.Sum(g => g.Quantity * g.UnitPrice).Value, 2)
                    };
        customer = query.ToList().OrderByDescending(bc => bc.Bought).ElementAt(0);
    }

    class BestCustomers : Customers
    {
        public int OrdersQty { get; set; }
        public decimal Bought { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private northwindContext context { get; set; }
    }
}
#pragma warning restore 1591
