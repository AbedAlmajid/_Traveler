#pragma checksum "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "631a2eca87396aa51d77ea247c358f9b74e8223e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HomeImage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HomeImage/Default.cshtml")]
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
#line 7 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\_ViewImports.cshtml"
using DemoTraveler.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"631a2eca87396aa51d77ea247c358f9b74e8223e", @"/Views/Shared/Components/HomeImage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d0626b13d2223b7dc98d17eb14cb1fa97bc187", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HomeImage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeImage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TourPackage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary py-md-3 px-md-5 mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 195, "\"", 203, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div id=\"header-carousel\" class=\"carousel slide\" data-ride=\"carousel\">\r\n            <div class=\"carousel-inner\">\r\n                <div class=\"carousel-item active\">\r\n                    <img class=\"w-100\"");
            BeginWriteAttribute("src", " src=\"", 419, "\"", 453, 2);
            WriteAttributeValue("", 425, "..\\", 425, 3, true);
#nullable restore
#line 14 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
WriteAttributeValue("", 428, Url.Content(item.Imagea), 428, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Image"">
                    <div class=""carousel-caption d-flex flex-column align-items-center justify-content-center"">
                        <div class=""p-3"" style=""max-width: 900px;"">
                            <h4 class=""text-white text-uppercase mb-md-3"">");
#nullable restore
#line 17 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
                                                                     Write(Localizer["Tours & Travel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <h1 class=\"display-3 text-white mb-md-4\">");
#nullable restore
#line 18 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
                                                                Write(Localizer["Let's Discover The World Together"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "631a2eca87396aa51d77ea247c358f9b74e8223e7833", async() => {
#nullable restore
#line 19 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
                                                                                                                      Write(Localizer["Book Now"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"carousel-item\">\r\n                    <img class=\"w-100\"");
            BeginWriteAttribute("src", " src=\"", 1201, "\"", 1235, 2);
            WriteAttributeValue("", 1207, "..\\", 1207, 3, true);
#nullable restore
#line 24 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
WriteAttributeValue("", 1210, Url.Content(item.Imageb), 1210, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Image"">
                    <div class=""carousel-caption d-flex flex-column align-items-center justify-content-center"">
                        <div class=""container"" style=""max-width: 900px;"">
                            <h4 class=""text-white text-uppercase mb-md-3"">");
#nullable restore
#line 27 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
                                                                     Write(Localizer["Tours & Travel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <h1 class=\"display-3 text-white mb-md-4\">");
#nullable restore
#line 28 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
                                                                Write(Localizer["Discover Amazing Places With Us"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1699, "\"", 1706, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary py-md-3 px-md-5 mt-2\">");
#nullable restore
#line 29 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
                                                                               Write(Localizer["Book Now"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 34 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
             if (CultureInfo.CurrentCulture.Name.StartsWith("ar"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <a class=""carousel-control-next"" href=""#header-carousel"" data-slide=""prev"">
                    <div class=""btn btn-dark"" style=""width: 45px; height: 45px;"">
                        <span class=""carousel-control-prev-icon mb-n2""></span>
                    </div>
                </a>
                <a class=""carousel-control-prev"" href=""#header-carousel"" data-slide=""next"">
                    <div class=""btn btn-dark"" style=""width: 45px; height: 45px;"">
                        <span class=""carousel-control-next-icon mb-n2""></span>
                    </div>
                </a>
");
#nullable restore
#line 46 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <a class=""carousel-control-prev"" href=""#header-carousel"" data-slide=""prev"">
                    <div class=""btn btn-dark"" style=""width: 45px; height: 45px;"">
                        <span class=""carousel-control-prev-icon mb-n2""></span>
                    </div>
                </a>
                <a class=""carousel-control-next"" href=""#header-carousel"" data-slide=""next"">
                    <div class=""btn btn-dark"" style=""width: 45px; height: 45px;"">
                        <span class=""carousel-control-next-icon mb-n2""></span>
                    </div>
                </a>
");
#nullable restore
#line 60 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 64 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Views\Shared\Components\HomeImage\Default.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeImage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
