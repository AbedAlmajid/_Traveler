#pragma checksum "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68c73c9fa2b9a4cd80f154321f04c0f50d7f0322"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Account_MyProfile), @"mvc.1.0.view", @"/Areas/Customer/Views/Account/MyProfile.cshtml")]
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
#line 1 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\_ViewImports.cshtml"
using DemoTraveler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\_ViewImports.cshtml"
using DemoTraveler.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\_ViewImports.cshtml"
using DemoTraveler.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c73c9fa2b9a4cd80f154321f04c0f50d7f0322", @"/Areas/Customer/Views/Account/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec454ee097b513998397066d2a5291fd32a220df", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Account_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Areas/Customer/Views/Shared/_CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\"");
            BeginWriteAttribute("style", " style=\"", 168, "\"", 203, 2);
            WriteAttributeValue("", 176, "direction:", 176, 10, true);
#nullable restore
#line 9 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
WriteAttributeValue("", 186, Localizer["dir"], 186, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n    <h2>");
#nullable restore
#line 12 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
   Write(Localizer["My Informatins"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <br />\r\n\r\n    <table class=\"table table-hover\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
           Write(Localizer["First Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\r\n            <td><b>");
#nullable restore
#line 18 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
           Write(Localizer["Last Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\r\n            <td><b>");
#nullable restore
#line 22 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
              Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
           Write(Localizer["Country Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\r\n            <td><b>");
#nullable restore
#line 26 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
              Write(Model.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
           Write(Localizer["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\r\n            <td><b>");
#nullable restore
#line 30 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
              Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
           Write(Localizer["Phone Number"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\r\n            <td><b>");
#nullable restore
#line 34 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Account\MyProfile.cshtml"
              Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
