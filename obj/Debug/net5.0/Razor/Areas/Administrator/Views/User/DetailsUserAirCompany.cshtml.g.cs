#pragma checksum "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\DetailsUserAirCompany.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d3f4b98d778dea4b0c96080cae39d5c015ac93a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_User_DetailsUserAirCompany), @"mvc.1.0.view", @"/Areas/Administrator/Views/User/DetailsUserAirCompany.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3f4b98d778dea4b0c96080cae39d5c015ac93a", @"/Areas/Administrator/Views/User/DetailsUserAirCompany.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7818f63a3dde9846399966efd4eeffb1586d8e0e", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_User_DetailsUserAirCompany : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserListAirCompany", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\DetailsUserAirCompany.cshtml"
  
    ViewData["Title"] = "Details AirCompany";
    Layout = "~/Areas/Administrator/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AirCompany Details</h1>\r\n\r\n<p>Id: ");
#nullable restore
#line 9 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\DetailsUserAirCompany.cshtml"
  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>First Name: ");
#nullable restore
#line 10 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\DetailsUserAirCompany.cshtml"
          Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Last Name: ");
#nullable restore
#line 11 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\DetailsUserAirCompany.cshtml"
         Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Email: ");
#nullable restore
#line 12 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\DetailsUserAirCompany.cshtml"
     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Phone Number: ");
#nullable restore
#line 13 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Administrator\Views\User\DetailsUserAirCompany.cshtml"
            Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3f4b98d778dea4b0c96080cae39d5c015ac93a7126", async() => {
                WriteLiteral("Back To List");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
