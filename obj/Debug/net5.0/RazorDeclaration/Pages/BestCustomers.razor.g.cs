// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomers.razor"
using Querys.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/best-customers")]
    public partial class BestCustomers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/BestCustomers.razor"
       

    IEnumerable<MostBoughtCustomers> mostBoughtCustomers;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        GetCustomers();
    }

    void GetCustomers()
    {
        try
        {

            var query = from c in context.Customers
                    join o in context.Orders on c.Id equals o.CustomerId
                    join od in context.OrderDetails on o.Id equals od.OrderId
                    group od by new { c.Id, c.FirstName, c.LastName } into g
                    select new MostBoughtCustomers
                    {
                        CustomerId = g.Key.Id,
                        CustomerName = g.Key.FirstName + " " + g.Key.LastName,
                        Bought = Math.Round(g.Sum(od => od.Quantity * od.UnitPrice).Value, 2)
                    };
            mostBoughtCustomers = query.ToList().OrderByDescending(m => m.Bought).Take(10);
        }
        catch (ArgumentNullException ane)
        {
        
        }


    }



    class MostBoughtCustomers
    {
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal? Bought { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private northwindContext context { get; set; }
    }
}
#pragma warning restore 1591
