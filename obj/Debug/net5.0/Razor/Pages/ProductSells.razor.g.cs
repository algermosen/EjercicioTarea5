#pragma checksum "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/ProductSells.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "576d742d2b6c099012e81a9064fa23ec427a080e"
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
#line 3 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/ProductSells.razor"
using Querys.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product-sells")]
    public partial class ProductSells : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Unidades  vendidas por producto</h3>");
#nullable restore
#line 7 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/ProductSells.razor"
 if (products == null || products.Count <= 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Querys.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "Productos no encontrados");
            __builder.CloseComponent();
#nullable restore
#line 10 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/ProductSells.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "ul");
#nullable restore
#line 14 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/ProductSells.razor"
         foreach (var p in products)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Querys.Components.List>(4);
            __builder.AddAttribute(5, "Bold", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(6, 
#nullable restore
#line 17 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/ProductSells.razor"
                       p.Product.ProductName

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(7, "Thin", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(8, 
#nullable restore
#line 18 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/ProductSells.razor"
                       p.Quantity

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 20 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/ProductSells.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 22 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/ProductSells.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "/Users/alejandro/Itla/C5/prog_3/tarea_5/Pages/ProductSells.razor"
       


    List<ProductQuantity> products;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        GetProducts();
    }

    void GetProducts()
    {
        products = context.OrderDetails
            .GroupBy(od => od.ProductId)
            .Select(g => new ProductQuantity
            {
                Quantity = g.Count(),
                ProductId = g.Key
            }).ToList();

        products.ForEach(p =>
        {
            p.Product = context.Products.Find(p.ProductId);
        });


    }

    class ProductQuantity
    {
        public int? ProductId { get; set; }
        public Products Product { get; set; }
        public int Quantity { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private northwindContext context { get; set; }
    }
}
#pragma warning restore 1591
