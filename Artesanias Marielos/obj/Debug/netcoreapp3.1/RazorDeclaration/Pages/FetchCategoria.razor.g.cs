// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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