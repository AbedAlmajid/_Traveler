#pragma checksum "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9587d5735656dffd75770bb0654565178996902d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutUs_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutUs/Default.cshtml")]
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
#line 7 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\_ViewImports.cshtml"
using DemoTraveler.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9587d5735656dffd75770bb0654565178996902d", @"/Views/Shared/Components/AboutUs/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d0626b13d2223b7dc98d17eb14cb1fa97bc187", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AboutUs_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AboutUs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
  
    var requestCulture = Context.Features.Get<IRequestCultureFeature>();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 17 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
 foreach (var item in Model)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
     if (CultureInfo.CurrentCulture.Name.StartsWith("en"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container-fluid py-5"">
            <div class=""container pt-5"">
                <div class=""row"">
                    <div class=""col-lg-6"" style=""min-height: 500px;"">
                        <div class=""position-relative h-100"">
                            <img class=""position-absolute w-100 h-100""");
            BeginWriteAttribute("src", " src=\"", 829, "\"", 866, 2);
            WriteAttributeValue("", 835, "..\\", 835, 3, true);
#nullable restore
#line 27 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
WriteAttributeValue("", 838, Url.Content(item.AboutImg1), 838, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""object-fit: cover;"">
                        </div>
                    </div>
                    <div class=""col-lg-6 "">
                        <div class=""about-text bg-white p-4 p-lg-5 my-lg-5"">
                            <h6 class=""text-primary text-uppercase"" style=""letter-spacing: 5px;"">");
#nullable restore
#line 32 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                                                                            Write(localizer["About Us"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <h1 class=\"mb-3\">");
#nullable restore
#line 33 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                        Write(localizer["We Provide Best Tour"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                                                           Write(localizer["Packages In Your Budget"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <p></p>\r\n                            <div class=\"row mb-4\">\r\n                                <div class=\"col-6\">\r\n                                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1530, "\"", 1567, 2);
            WriteAttributeValue("", 1536, "../", 1536, 3, true);
#nullable restore
#line 37 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
WriteAttributeValue("", 1539, Url.Content(item.AboutImg2), 1539, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1568, "\"", 1574, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"col-6\">\r\n                                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1729, "\"", 1766, 2);
            WriteAttributeValue("", 1735, "../", 1735, 3, true);
#nullable restore
#line 40 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
WriteAttributeValue("", 1738, Url.Content(item.AboutImg3), 1738, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1767, "\"", 1773, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                            </div>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1883, "\"", 1890, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary mt-1\">");
#nullable restore
#line 43 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                                               Write(localizer["Book Now"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 49 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid py-5"">
    <div class=""container pt-5"">
        <div class=""row"">
            <div class=""col-lg-6"" style=""min-height: 500px;"">
                <div class=""position-relative h-100"">
                    <img class=""position-absolute w-100 h-100""");
            BeginWriteAttribute("src", " src=\"", 2370, "\"", 2407, 2);
            WriteAttributeValue("", 2376, "..\\", 2376, 3, true);
#nullable restore
#line 57 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
WriteAttributeValue("", 2379, Url.Content(item.AboutImg1), 2379, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""object-fit: cover;"">
                </div>
            </div>
            <div class=""col-lg-6 "">
                <div class=""about-text bg-white p-4 p-lg-5 my-lg-5"">
                    <h6 class=""text-primary text-uppercase"" style=""letter-spacing: 5px;"">");
#nullable restore
#line 62 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                                                                    Write(localizer["About Us"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h1 class=\"mb-3\">");
#nullable restore
#line 63 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                Write(localizer["We Provide Best Tour"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 63 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                                                   Write(localizer["Packages In Your Budget"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p></p>\r\n                    <div class=\"row mb-4\">\r\n                        <div class=\"col-6\">\r\n                            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 2991, "\"", 3028, 2);
            WriteAttributeValue("", 2997, "../", 2997, 3, true);
#nullable restore
#line 67 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
WriteAttributeValue("", 3000, Url.Content(item.AboutImg2), 3000, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3029, "\"", 3035, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"col-6\">\r\n                            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 3166, "\"", 3203, 2);
            WriteAttributeValue("", 3172, "../", 3172, 3, true);
#nullable restore
#line 70 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
WriteAttributeValue("", 3175, Url.Content(item.AboutImg3), 3175, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3204, "\"", 3210, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3296, "\"", 3303, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary mt-1\">");
#nullable restore
#line 73 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                                       Write(localizer["Book Now"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 79 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\AboutUs\Default.cshtml"
     

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> locOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AboutUs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
