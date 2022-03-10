#pragma checksum "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4082f44cf55763875b68be7e73485e86a8c72da"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission07.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/_Imports.razor"
using Mission07.Models;

#line default
#line hidden
#nullable disable
    public partial class PurchaseTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenElement(7, "th");
            __builder.AddAttribute(8, "colspan", "5");
            __builder.AddAttribute(9, "class", "text-center");
            __builder.AddContent(10, 
#nullable restore
#line 4 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
                                                 TableTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 8 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
         if (Purchases?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
             foreach (Purchase p in Purchases)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 13 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
                         p.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 14 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
                         p.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.AddMarkupContent(25, "<th>Book</th>\n                    ");
            __builder.AddMarkupContent(26, "<th>Quantity</th>\n\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\n                        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-small btn-danger");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
                                                                             x => PurchaseSelected.InvokeAsync(p.PurchasID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, 
#nullable restore
#line 19 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
                                                                                                                               ButtonLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n");
#nullable restore
#line 23 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
                 foreach (BasketLineItem bli in p.Lines)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                        ");
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "\n                            <td colspan=\"2\"></td>\n                            ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 27 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
                                 bli.Book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                            ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 28 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
                                 bli.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n");
#nullable restore
#line 30 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
                     
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "            ");
            __builder.AddMarkupContent(47, "<tr>\n                <td colspan=\"5\" class=\"text-center\">No Orders</td>\n            </tr>\n");
#nullable restore
#line 38 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/PurchaseTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Purchases";

    [Parameter]
    public IEnumerable<Purchase> Purchases { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Shipped";

    [Parameter]
    public EventCallback<int> PurchaseSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
