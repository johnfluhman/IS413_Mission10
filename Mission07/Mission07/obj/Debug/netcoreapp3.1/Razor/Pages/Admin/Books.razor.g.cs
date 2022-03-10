#pragma checksum "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1f4bd4f73a8f4f87043ecc506e363f3db80c9d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Books : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<thead>\n        <tr>\n            <td>Book ID</td>\n            <td>Title</td>\n            <td>Author</td>\n        </tr>\n    </thead>\n\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 15 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
         if (BookData?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
             foreach (Book b in BookData)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 20 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
                         b.BookId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 21 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
                         b.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 22 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
                         b.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddMarkupContent(19, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(22, "href", 
#nullable restore
#line 24 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
                                                                    GetDetailsUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(24, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 27 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
                                                                       GetEditUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(33, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\n                        ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
                                                                          x => RemoveBook(b)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n");
#nullable restore
#line 33 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "            ");
            __builder.AddMarkupContent(46, "<tr>\n                <td colspan=\"5\" class=\"text-center\">No Books</td>\n            </tr>\n");
#nullable restore
#line 40 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddAttribute(52, "href", "/admin/books/create");
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(54, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/Users/johnfluhman/Documents/GitHub/IS413_Mission10/Mission07/Mission07/Pages/Admin/Books.razor"
       

    public IBookstoreRepository repo => Service;
    public IEnumerable<Book> BookData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        BookData = await repo.Books.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/books/details/{id}";
    public string GetEditUrl(long id) => $"/admin/books/edit/{id}";

    public async Task RemoveBook (Book b)
    {
        repo.DeleteBook(b);
        await UpdateData();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
