#pragma checksum "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\Shared\Components\Partner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d721392713c7975972c24db366c2754504dc382e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Partner_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Partner/Default.cshtml")]
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
#line 1 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\_ViewImports.cshtml"
using DemoTraveler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\_ViewImports.cshtml"
using DemoTraveler.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\_ViewImports.cshtml"
using DemoTraveler.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d721392713c7975972c24db366c2754504dc382e", @"/Views/Shared/Components/Partner/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d0626b13d2223b7dc98d17eb14cb1fa97bc187", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Partner_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Partner>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\Shared\Components\Partner\Default.cshtml"
        
    ViewData["Title"] = "About Us";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid py-5"">
    <div class=""container pt-5 pb-3"">
        <div class=""text-center mb-3 pb-3"">
            <h6 class=""text-primary text-uppercase"" style=""letter-spacing: 5px;"">Guides</h6>
            <h1>Our Travel Partners</h1>
        </div>
        <div class=""row"">
");
#nullable restore
#line 15 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\Shared\Components\Partner\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-3 col-md-4 col-sm-6 pb-2"">
                    <div class=""team-item bg-white mb-4"">
                        <div class=""team-img position-relative overflow-hidden"">
                            <img class=""img-fluid w-100""");
            BeginWriteAttribute("src", " src=\"", 701, "\"", 739, 2);
            WriteAttributeValue("", 707, "..\\", 707, 3, true);
#nullable restore
#line 20 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\Shared\Components\Partner\Default.cshtml"
WriteAttributeValue("", 710, Url.Content(item.PartnerImg), 710, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 740, "\"", 746, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            \r\n                        </div>\r\n                        <div class=\"text-center py-4\">\r\n                            <h5 class=\"text-truncate\">");
#nullable restore
#line 24 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\Shared\Components\Partner\Default.cshtml"
                                                 Write(item.PartnerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"m-0\">");
#nullable restore
#line 25 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\Shared\Components\Partner\Default.cshtml"
                                      Write(item.PartnerJop);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 29 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Travel\Views\Shared\Components\Partner\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Partner>> Html { get; private set; }
    }
}
#pragma warning restore 1591