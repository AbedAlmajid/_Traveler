#pragma checksum "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\UserRoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f26db0475ba790ac9669b0f2f30fd4c05ead38c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_User_UserRoleList), @"mvc.1.0.view", @"/Areas/Administrator/Views/User/UserRoleList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\_ViewImports.cshtml"
using DemoTraveler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\_ViewImports.cshtml"
using DemoTraveler.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\_ViewImports.cshtml"
using DemoTraveler.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f26db0475ba790ac9669b0f2f30fd4c05ead38c7", @"/Areas/Administrator/Views/User/UserRoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7818f63a3dde9846399966efd4eeffb1586d8e0e", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_User_UserRoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserRoleViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\UserRoleList.cshtml"
  
    ViewData["Title"] = "User Role";
    Layout = "~/Areas/Administrator/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Role Name</th>\r\n            <th>Users</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\UserRoleList.cshtml"
         foreach (var roleViewModel in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\UserRoleList.cshtml"
               Write(roleViewModel.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <ul>\r\n");
#nullable restore
#line 26 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\UserRoleList.cshtml"
                         foreach (var user in roleViewModel.Users)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
#nullable restore
#line 28 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\UserRoleList.cshtml"
                           Write(user);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\UserRoleList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\UserRoleList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> locOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserRoleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
