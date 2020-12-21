#pragma checksum "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95beeec79fc37b31c5eadbaca80ba31a87415aab"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gerio\source\repos\bapp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gerio\source\repos\bapp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gerio\source\repos\bapp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gerio\source\repos\bapp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gerio\source\repos\bapp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gerio\source\repos\bapp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gerio\source\repos\bapp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gerio\source\repos\bapp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gerio\source\repos\bapp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gerio\source\repos\bapp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gerio\source\repos\bapp\BlazorApp\_Imports.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row bg-light");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-bordered");
            __builder.AddMarkupContent(6, "<thead class=\"thead-dark\"><tr><th>Name</th>\r\n                    <th>Email</th>\r\n                    <th>Phone</th>\r\n                    <th>Domain</th>\r\n                    <th>Notes</th></tr></thead>\r\n            ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 19 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                 if (BlazorUsers.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                     foreach (var blazorUser in BlazorUsers)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                      (() => SetblazorUsersForUpdate(blazorUser))

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 24 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                 blazorUser.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                 blazorUser.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                 blazorUser.Phone_Number

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 27 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                 blazorUser.Domain

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 28 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                 blazorUser.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-danger");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                                         (() => DeleteBlazorUser(blazorUser))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<tr><td colspan=\"6\"><strong>No products available</strong></td></tr>");
#nullable restore
#line 36 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row m-5");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-5 bg-light m-2 justify-content-start");
            __builder.AddMarkupContent(36, "<div class=\"p-3 mb-3 bg-primary text-white text-center\">Add New User</div>\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(37);
            __builder.AddAttribute(38, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 46 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                              NewBlazorUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "<label for=\"name\">Name</label>\r\n                    ");
                __builder2.OpenElement(43, "input");
                __builder2.AddAttribute(44, "type", "text");
                __builder2.AddAttribute(45, "id", "name");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                                                    NewBlazorUser.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewBlazorUser.Name = __value, NewBlazorUser.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n                ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "<label for=\"email\">Email</label>\r\n                    ");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "type", "text");
                __builder2.AddAttribute(55, "id", "email");
                __builder2.AddAttribute(56, "class", "form-control");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                                               NewBlazorUser.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewBlazorUser.Email = __value, NewBlazorUser.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n                ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group");
                __builder2.AddMarkupContent(62, "<label for=\"phone\">Phone</label>\r\n                    ");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "type", "text");
                __builder2.AddAttribute(65, "id", "phone");
                __builder2.AddAttribute(66, "class", "form-control");
                __builder2.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                                               NewBlazorUser.Phone_Number

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewBlazorUser.Phone_Number = __value, NewBlazorUser.Phone_Number));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n\r\n                ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "<label for=\"domain\">Domain</label>\r\n                    ");
                __builder2.OpenElement(73, "input");
                __builder2.AddAttribute(74, "type", "text");
                __builder2.AddAttribute(75, "id", "domain");
                __builder2.AddAttribute(76, "class", "form-control");
                __builder2.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                                                NewBlazorUser.Domain

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewBlazorUser.Domain = __value, NewBlazorUser.Domain));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n\r\n                ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "<label for=\"notes\">Notes</label>\r\n                    ");
                __builder2.OpenElement(83, "input");
                __builder2.AddAttribute(84, "type", "text");
                __builder2.AddAttribute(85, "id", "notes");
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                                               NewBlazorUser.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewBlazorUser.Notes = __value, NewBlazorUser.Notes));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n\r\n                ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "text-center p-3 mb-3");
                __builder2.OpenElement(92, "button");
                __builder2.AddAttribute(93, "class", "btn btn-info");
                __builder2.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                           AddNewblazorUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(95, " Add User");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n        ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "col-5 bg-light m-2 justify-content-end");
            __builder.AddMarkupContent(99, "<div class=\"p-3 mb-1 bg-primary text-white text-center\">Update User</div>\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(100);
            __builder.AddAttribute(101, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 81 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                              UpdateBlazorUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "form-group");
                __builder2.AddMarkupContent(105, "<label for=\"name\">Product Name</label>\r\n                    ");
                __builder2.OpenElement(106, "input");
                __builder2.AddAttribute(107, "type", "text");
                __builder2.AddAttribute(108, "id", "name");
                __builder2.AddAttribute(109, "class", "form-control");
                __builder2.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 84 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                                                    UpdateBlazorUser.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateBlazorUser.Name = __value, UpdateBlazorUser.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n\r\n                ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group");
                __builder2.AddMarkupContent(115, "<label for=\"email\">Email</label>\r\n                    ");
                __builder2.OpenElement(116, "input");
                __builder2.AddAttribute(117, "type", "text");
                __builder2.AddAttribute(118, "id", "email");
                __builder2.AddAttribute(119, "class", "form-control");
                __builder2.AddAttribute(120, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                                               UpdateBlazorUser.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateBlazorUser.Email = __value, UpdateBlazorUser.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n\r\n                ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "form-group");
                __builder2.AddMarkupContent(125, "<label for=\"phone\">Phone</label>\r\n                    ");
                __builder2.OpenElement(126, "input");
                __builder2.AddAttribute(127, "type", "text");
                __builder2.AddAttribute(128, "id", "phone");
                __builder2.AddAttribute(129, "class", "form-control");
                __builder2.AddAttribute(130, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 94 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                                               UpdateBlazorUser.Phone_Number

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(131, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateBlazorUser.Phone_Number = __value, UpdateBlazorUser.Phone_Number));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n\r\n                ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "form-group");
                __builder2.AddMarkupContent(135, "<label for=\"domain\">Domain</label>\r\n                    ");
                __builder2.OpenElement(136, "input");
                __builder2.AddAttribute(137, "type", "text");
                __builder2.AddAttribute(138, "id", "domain");
                __builder2.AddAttribute(139, "class", "form-control");
                __builder2.AddAttribute(140, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                                                UpdateBlazorUser.Domain

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(141, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateBlazorUser.Domain = __value, UpdateBlazorUser.Domain));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n\r\n                ");
                __builder2.OpenElement(143, "div");
                __builder2.AddAttribute(144, "class", "form-group");
                __builder2.AddMarkupContent(145, "<label for=\"notes\">Notes</label>\r\n                    ");
                __builder2.OpenElement(146, "input");
                __builder2.AddAttribute(147, "type", "text");
                __builder2.AddAttribute(148, "id", "notes");
                __builder2.AddAttribute(149, "class", "form-control");
                __builder2.AddAttribute(150, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 104 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                                               UpdateBlazorUser.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(151, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UpdateBlazorUser.Notes = __value, UpdateBlazorUser.Notes));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n\r\n                ");
                __builder2.OpenElement(153, "div");
                __builder2.AddAttribute(154, "class", "text-center p-3 mb-3");
                __builder2.OpenElement(155, "button");
                __builder2.AddAttribute(156, "class", "btn btn-info");
                __builder2.AddAttribute(157, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
                                                           UpdateblazorUserData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(158, " Update User");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\gerio\source\repos\bapp\BlazorApp\Pages\Index.razor"
       

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
