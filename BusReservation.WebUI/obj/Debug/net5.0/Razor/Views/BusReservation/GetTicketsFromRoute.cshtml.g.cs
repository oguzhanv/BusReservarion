#pragma checksum "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1332bbc3420834b03b6a95a1e0b4ad5ff4380010"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BusReservation_GetTicketsFromRoute), @"mvc.1.0.view", @"/Views/BusReservation/GetTicketsFromRoute.cshtml")]
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
#line 1 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1332bbc3420834b03b6a95a1e0b4ad5ff4380010", @"/Views/BusReservation/GetTicketsFromRoute.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68777c9f1237a2539b6b54c76e3699e777332a2", @"/Views/_ViewImports.cshtml")]
    public class Views_BusReservation_GetTicketsFromRoute : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BusReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetPassangerInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h4 class=\"text-center mb-4\">");
#nullable restore
#line 4 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                        Write(ViewBag.From);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 4 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                        Write(ViewBag.ToWhere);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>


<div class=""seat-row"">
    <ul class=""d-flex"">
        <li class=""seat-info m-1 d-flex"">
            <div class=""seat selected-woman seat-pre""></div>
            <div class=""ms-3"">
                <p>Kadın Dolu</p>
                <p>Koltuk</p>
            </div>
        </li>
        <li class=""seat-info m-1 d-flex"">
            <div class=""seat selected-man seat-pre""></div>
            <div class=""ms-3"">
                <p>Erkek Dolu</p>
                <p>Koltuk</p>
            </div>
        </li>
        <li class=""seat-info m-1 d-flex"">
            <div class=""seat empty-seat seat-pre""></div>
            <div class=""ms-3"">
                <p>Boş Koltuk</p>
                <p>Alınabilir</p>
            </div>
        </li>
    </ul>
</div>
<center>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1332bbc3420834b03b6a95a1e0b4ad5ff43800107017", async() => {
                WriteLiteral("\r\n        <div class=\"seat-row parent\">\r\n");
#nullable restore
#line 35 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
             for (int i = 1; i < 40; i++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                 foreach (var item in Model)
                {

                    List<int> SelectedSeats = new List<int>();
                    if (i == item.TicketSeatNo)
                    {
                        SelectedSeats.Add(i);

                        foreach (var seat in SelectedSeats)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                if (j == seat)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                     if (item.TicketGender == "Erkek")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"seat selected-man child\">");
#nullable restore
#line 53 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                                                        Write(j);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 54 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                    }
                                    else if (item.TicketGender == "Kadın")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"seat selected-woman child\">");
#nullable restore
#line 57 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                                                          Write(j);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 58 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                     
                                    i++;
                                }
                            }
                        }
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button type=\"submit\" class=\"seat child\"");
                BeginWriteAttribute("value", " value=\"", 2314, "\"", 2324, 1);
#nullable restore
#line 65 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
WriteAttributeValue("", 2322, i, 2322, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"seatNo\">");
#nullable restore
#line 65 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                                                             Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
#nullable restore
#line 66 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <input type=\"hidden\" name=\"FromWhere\"");
                BeginWriteAttribute("value", " value=\"", 2429, "\"", 2450, 1);
#nullable restore
#line 68 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
WriteAttributeValue("", 2437, ViewBag.From, 2437, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"ToWhere\"");
                BeginWriteAttribute("value", " value=\"", 2499, "\"", 2523, 1);
#nullable restore
#line 69 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
WriteAttributeValue("", 2507, ViewBag.ToWhere, 2507, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"routeId\"");
                BeginWriteAttribute("value", " value=\"", 2572, "\"", 2590, 1);
#nullable restore
#line 70 "C:\Users\oguzh\Desktop\BusReservation_oguzhan_varli\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
WriteAttributeValue("", 2580, ViewBag.x, 2580, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</center>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
