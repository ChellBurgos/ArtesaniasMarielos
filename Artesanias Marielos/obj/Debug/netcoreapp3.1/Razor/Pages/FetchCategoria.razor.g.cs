#pragma checksum "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85b0a5c9909747ef3bf1cf7948df02af91cce02b"
// <auto-generated/>
#pragma warning disable 1591
namespace Artesanias_Marielos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Artesanias_Marielos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Artesanias_Marielos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Artesanias_Marielos.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Artesanias_Marielos.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Artesanias_Marielos.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Artesanias_Marielos.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\_Imports.razor"
using Artesanias_Marielos.DataAccess;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categorialist")]
    public partial class FetchCategoria : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.AddMarkupContent(1, @"<style>
    .sort-th {
        cursor: pointer;
    }

    .fa {
        float: right;
    }

    .btn-custom {
        color: black;
        float: left;
        padding: 8px 16px;
        text-decoration: none;
        transition: background-color .3s;
        border: 2px solid #000;
        margin: 0px 5px 0px 5px;
    }
</style>

");
            __builder.AddMarkupContent(2, "<div>\r\n    <a class=\"btn btn-primary\" href=\"/addCategoria\">Add</a>\r\n</div>\r\n<br>\r\n\r\n");
#nullable restore
#line 31 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
 if (categoriaModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 34 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row col-md-3 pull-right");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "id", "txtSearch");
            __builder.AddAttribute(12, "placeholder", "Search Titles...");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                                                                                     SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "thead");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "th");
            __builder.AddAttribute(26, "class", "sort-th");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                                () => SortTable("IdCategoria")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                    Id\r\n                    ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "fa" + " " + (
#nullable restore
#line 45 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                      SetSortIcon("IdCategoria")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "th");
            __builder.AddAttribute(34, "class", "sort-th");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                                () => SortTable("Categoria")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                    Categoria\r\n                    ");
            __builder.OpenElement(37, "span");
            __builder.AddAttribute(38, "class", "fa" + " " + (
#nullable restore
#line 49 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                      SetSortIcon("Categoria")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "th");
            __builder.AddAttribute(42, "class", "sort-th");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                                () => SortTable("Estado")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\r\n                    Estado\r\n                    ");
            __builder.OpenElement(45, "span");
            __builder.AddAttribute(46, "class", "fa" + " " + (
#nullable restore
#line 53 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                      SetSortIcon("Estado")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.AddMarkupContent(49, "<th>Action</th>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "tbody");
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 59 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
             if (categoriaModel == null || categoriaModel.Count == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "                ");
            __builder.AddMarkupContent(55, "<tr>\r\n                    <td colspan=\"3\">\r\n                        No Records to display\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 66 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
            }
            else
            {
                foreach (var categoria in categoriaModel)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                    ");
            __builder.OpenElement(57, "tr");
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 72 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                             categoria.IdCategoria

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 73 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                             categoria.Categoria

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 74 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                             categoria.Estado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "td");
            __builder.AddMarkupContent(69, "\r\n                            ");
            __builder.OpenElement(70, "a");
            __builder.AddAttribute(71, "class", "btn btn-primary");
            __builder.AddAttribute(72, "href", "/editCategoria/" + (
#nullable restore
#line 76 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                                                             categoria.IdCategoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "  |\r\n                            ");
            __builder.OpenElement(75, "a");
            __builder.AddAttribute(76, "class", "btn btn-danger");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                                                () => DeleteCategoria(categoria.IdCategoria)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 80 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "pagination");
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "class", "btn btn-custom");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                                  async ()=>await NavigateToPage("previous")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(91, "Prev");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n");
#nullable restore
#line 88 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
         for (int i = startPage; i <= endPage; i++)
        {
            var currentPage = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "            ");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "class", "btn" + " btn-custom" + " pagebutton" + " " + (
#nullable restore
#line 91 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                                       currentPage==curPage?"btn-danger":""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                                                                                         async () =>await refreshRecords(currentPage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.AddContent(98, 
#nullable restore
#line 92 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                 currentPage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(99, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 94 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "class", "btn btn-custom");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
                                                  async ()=>await NavigateToPage("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(105, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 99 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "D:\VisualStudio\Artesanias Marielos P\Artesanias Marielos\Pages\FetchCategoria.razor"
       
    private string searchTerm;
    private string SearchTerm
    {
        get { return searchTerm; }
        set { searchTerm = value; FilterRecords(); }
    }

    List<Categorias> categoriaModel;
    Categorias articleEntity = new Categorias();


    #region Pagination

    int totalPages;
    int totalRecords;
    int curPage;
    int pagerSize;
    int pageSize;
    int startPage;
    int endPage;
    string sortColumnName = "IdCategoria";
    string sortDir = "DESC";

    #endregion

    protected override async Task OnInitializedAsync()
    {
        //display total page buttons
        pagerSize = 3;
        pageSize = 5;
        curPage = 1;
        categoriaModel = await CategoriaManager.ListAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
        totalRecords = await CategoriaManager.Count(searchTerm);
        totalPages = (int)Math.Ceiling(totalRecords / (decimal)pageSize);
        SetPagerSize("forward");
    }


    protected async Task DeleteCategoria(int id)
    {
        await CategoriaManager.Delete(id);
        categoriaModel = await CategoriaManager.ListAll((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
    }

    private bool isSortedAscending;
    private string activeSortColumn;

    private async Task<List<Categorias>> SortRecords(string columnName, string dir)
    {
        return await CategoriaManager.ListAll((curPage - 1) * pageSize, pageSize, columnName, dir, searchTerm);
    }

    private async Task SortTable(string columnName)
    {
        if (columnName != activeSortColumn)
        {
            categoriaModel = await SortRecords(columnName, "ASC");
            isSortedAscending = true;
            activeSortColumn = columnName;
        }
        else
        {
            if (isSortedAscending)
            {
                categoriaModel = await SortRecords(columnName, "DESC");
            }
            else
            {
                categoriaModel = await SortRecords(columnName, "ASC");
            }

            isSortedAscending = !isSortedAscending;
        }
        sortColumnName = columnName;
        sortDir = isSortedAscending ? "ASC" : "DESC";
    }

    private string SetSortIcon(string columnName)
    {
        if (activeSortColumn != columnName)
        {
            return string.Empty;
        }
        if (isSortedAscending)
        {
            return "fa-sort-up";
        }
        else
        {
            return "fa-sort-down";
        }
    }

    public async Task refreshRecords(int currentPage)
    {
        categoriaModel = await CategoriaManager.ListAll((currentPage - 1) * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
        curPage = currentPage;
        this.StateHasChanged();
    }

    public void SetPagerSize(string direction)
    {
        if (direction == "forward" && endPage < totalPages)
        {
            startPage = endPage + 1;
            if (endPage + pagerSize < totalPages)
            {
                endPage = startPage + pagerSize - 1;
            }
            else
            {
                endPage = totalPages;
            }
            this.StateHasChanged();
        }
        else if (direction == "back" && startPage > 1)
        {
            endPage = startPage - 1;
            startPage = startPage - pagerSize;
        }
        else
        {
            startPage = 1;
            endPage = totalPages;
        }
    }

    public async Task NavigateToPage(string direction)
    {
        if (direction == "next")
        {
            if (curPage < totalPages)
            {
                if (curPage == endPage)
                {
                    SetPagerSize("forward");
                }
                curPage += 1;
            }
        }
        else if (direction == "previous")
        {
            if (curPage > 1)
            {
                if (curPage == startPage)
                {
                    SetPagerSize("back");
                }
                curPage -= 1;
            }
        }
        await refreshRecords(curPage);
    }

    public void FilterRecords()
    {
        endPage = 0;
        this.OnInitializedAsync().Wait();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoriaManager CategoriaManager { get; set; }
    }
}
#pragma warning restore 1591