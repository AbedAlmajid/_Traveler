#pragma checksum "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\Client\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "089ac4cfd24250b5484633ebd9ead5c56c641bf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Client_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Client/Default.cshtml")]
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
#line 1 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\_ViewImports.cshtml"
using DemoTraveler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\_ViewImports.cshtml"
using DemoTraveler.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"089ac4cfd24250b5484633ebd9ead5c56c641bf3", @"/Views/Shared/Components/Client/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6325ad69784e179b4747c81b97ca68776a231e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Client_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid py-5"">
    <div class=""container py-5"">
        <div class=""text-center mb-3 pb-3"">
            <h6 class=""text-primary text-uppercase"" style=""letter-spacing: 5px;"">Testimonial</h6>
            <h1>What Say Our Clients</h1>
        </div>
        <div class=""owl-carousel testimonial-carousel"">
");
#nullable restore
#line 9 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\Client\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"text-center pb-4\">\r\n                    <img class=\"img-fluid mx-auto\"");
            BeginWriteAttribute("src", " src=\"", 513, "\"", 550, 2);
            WriteAttributeValue("", 519, "../", 519, 3, true);
#nullable restore
#line 12 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\Client\Default.cshtml"
WriteAttributeValue("", 522, Url.Content(item.ClientImg), 522, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100px; height: 100px;\">\r\n                    <div class=\"testimonial-text bg-white p-4 mt-n5\">\r\n                        <p class=\"mt-5\">\r\n                           ");
#nullable restore
#line 15 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\Client\Default.cshtml"
                      Write(item.ClientDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <h5 class=\"text-truncate\">");
#nullable restore
#line 17 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\Client\Default.cshtml"
                                             Write(item.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <span>");
#nullable restore
#line 18 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\Client\Default.cshtml"
                         Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 21 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\Client\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Testimonial End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
