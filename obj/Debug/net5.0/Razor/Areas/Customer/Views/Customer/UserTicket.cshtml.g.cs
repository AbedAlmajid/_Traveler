#pragma checksum "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1520f09adc9ae04c76f92d4131f65a715e609183"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Customer_UserTicket), @"mvc.1.0.view", @"/Areas/Customer/Views/Customer/UserTicket.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1520f09adc9ae04c76f92d4131f65a715e609183", @"/Areas/Customer/Views/Customer/UserTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec454ee097b513998397066d2a5291fd32a220df", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Customer_UserTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DemoTraveler.Models.UserTicket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Destination", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
  
    ViewData["Title"] = "UserTicket";
    Layout = "~/Areas/Customer/Views/Shared/_CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid py-5\" style=\"min-height:900px\"");
            BeginWriteAttribute("dir", "dir=\"", 228, "\"", 250, 1);
#nullable restore
#line 7 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
WriteAttributeValue("", 233, Localizer["rtd"], 233, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"container pt-5\">\r\n");
#nullable restore
#line 9 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
         if (Model.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>");
#nullable restore
#line 11 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
           Write(Localizer["My Ticket"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <table class=\"table table-hover\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 18 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                       Write(Localizer["My Ticket"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 21 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                       Write(Html.DisplayNameFor(model => model.Booking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 31 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 31 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.ApplicationUser.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 32 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ApplicationUser.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 35 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Brand Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 35 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Ticket.BrandName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 37 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["From"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 37 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Ticket.FromCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 39 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["To"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 39 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Ticket.ToCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 41 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["From Airport"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 41 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Ticket.FromAirport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 43 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["To Airport"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 43 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Ticket.ToAirport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 45 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Depart Time"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :");
#nullable restore
#line 45 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Ticket.DepartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 47 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Arrive Time"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 47 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Ticket.ArriveTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 49 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Depart Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 49 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Ticket.DepartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 51 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Flight Duration"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 51 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Ticket.FlightDuration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 53 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Weight"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 53 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Ticket.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral(" KG\r\n                                <br />\r\n                                ");
#nullable restore
#line 55 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 55 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.Ticket.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 57 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Flight Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 57 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Ticket.FlightType.TypeFlight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 59 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Ticket Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 59 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Ticket.TicketType.TypeTicket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 62 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Passenger Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 62 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Booking.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 62 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                                                                                Write(Html.DisplayFor(modelItem => item.Booking.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 64 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["National Number"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 64 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Booking.NationalNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 66 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Passport Number"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 66 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Booking.PassportNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 68 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 68 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Booking.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 70 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["ZipCode"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 70 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Booking.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 72 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["PhoneNumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 72 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Booking.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 74 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                           Write(Localizer["Payment status"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                 if (item.Booking.Status == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h3 class=\"text-primary\">");
#nullable restore
#line 77 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                        Write(Localizer["Payment is Done"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 78 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h3 class=\"text-danger\">");
#nullable restore
#line 81 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                       Write(Localizer["Payment is Not Done"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1520f09adc9ae04c76f92d4131f65a715e60918325212", async() => {
#nullable restore
#line 82 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                                                                                                                Write(Localizer["Payment"]);

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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                                                    WriteLiteral(item.BookingId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 83 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 86 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 89 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>");
#nullable restore
#line 92 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
           Write(Localizer["My Ticket"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <br />\r\n            <br />\r\n            <p>");
#nullable restore
#line 95 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
          Write(Localizer["No Ticket Available"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <label class=\"form-group\">");
#nullable restore
#line 96 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                 Write(Localizer["Click Book Now for Booking Ticket"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            <br />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1520f09adc9ae04c76f92d4131f65a715e60918330103", async() => {
#nullable restore
#line 98 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
                                                                                             Write(Localizer["Book Now"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 99 "C:\Users\ABOOD ALAMAYREH\OneDrive\سطح المكتب\Traveler\Areas\Customer\Views\Customer\UserTicket.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DemoTraveler.Models.UserTicket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
