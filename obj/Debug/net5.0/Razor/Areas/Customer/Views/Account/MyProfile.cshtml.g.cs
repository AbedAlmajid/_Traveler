#pragma checksum "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\Account\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eda86976489bfca2a649de7fc0e1120e8c824d7d"
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
#line 1 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\_ViewImports.cshtml"
using DemoTraveler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\_ViewImports.cshtml"
using DemoTraveler.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\_ViewImports.cshtml"
using DemoTraveler.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda86976489bfca2a649de7fc0e1120e8c824d7d", @"/Areas/Customer/Views/Account/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec454ee097b513998397066d2a5291fd32a220df", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Account_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\Account\MyProfile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Areas/Customer/Views/Shared/_CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>My Profile</h2>\r\n<hr />\r\n<p>First Name: <b> ");
#nullable restore
#line 10 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\Account\MyProfile.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n<br />\r\n<p>Last Name: <b>");
#nullable restore
#line 12 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\Account\MyProfile.cshtml"
            Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n<br />\r\n<p>Birth Day: <b>");
#nullable restore
#line 14 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\Account\MyProfile.cshtml"
            Write(Model.BirthDay.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n<br />\r\n<p>Email:  <b>");
#nullable restore
#line 16 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\Account\MyProfile.cshtml"
         Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b> </p>\r\n<br />\r\n<p>Phone Number: <b>");
#nullable restore
#line 18 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Areas\Customer\Views\Account\MyProfile.cshtml"
               Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>");
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