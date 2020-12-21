// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gerio\source\repos\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gerio\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gerio\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gerio\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gerio\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gerio\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gerio\source\repos\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gerio\source\repos\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gerio\source\repos\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gerio\source\repos\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gerio\source\repos\BlazorApp\_Imports.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\gerio\source\repos\BlazorApp\Pages\Index.razor"
       

    List<BlazorUser> BlazorUsers = new List<BlazorUser>();
    protected override async Task OnInitializedAsync()
    {
        await RefreshblazorUsers();
    }

    private async Task RefreshblazorUsers()
    {
        BlazorUsers = await service.GetBlazorUsersAsync();
    }

    public BlazorUser NewBlazorUser { get; set; } = new BlazorUser();
    private async Task AddNewblazorUser()
    {
        await service.AddBlazorUsersAsync(NewBlazorUser);
        NewBlazorUser = new BlazorUser();
        await RefreshblazorUsers();
    }

    BlazorUser UpdateBlazorUser = new BlazorUser();
    private void SetblazorUsersForUpdate(BlazorUser blazorUser)
    {
        UpdateBlazorUser = blazorUser;
    }

    private async Task UpdateblazorUserData()
    {
        await service.UpdateBlazorUsersAsync(UpdateBlazorUser);
        await RefreshblazorUsers();
    }

    private async Task DeleteBlazorUser(BlazorUser blazorUser)
    {
        await service.DeleteBlazorUserAsync(blazorUser);
        await RefreshblazorUsers();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorUsersServices service { get; set; }
    }
}
#pragma warning restore 1591
