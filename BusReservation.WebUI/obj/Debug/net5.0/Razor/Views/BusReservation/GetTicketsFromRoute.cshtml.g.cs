#pragma checksum "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "065e7ef9703aade740490ef25a14d85b6d179eec"
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
#line 1 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"065e7ef9703aade740490ef25a14d85b6d179eec", @"/Views/BusReservation/GetTicketsFromRoute.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68777c9f1237a2539b6b54c76e3699e777332a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BusReservation_GetTicketsFromRoute : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicketWithList>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("seat child"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BusReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetPassangerInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h4 class=\"text-center mb-4\">");
#nullable restore
#line 4 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                        Write(Model.TicketFromWhere);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 4 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                                 Write(Model.TicketToWhere);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>


<div class=""seat-row"">
    <ul class=""d-flex"">
        <li class=""seat-info m-1 d-flex"">
            <div class=""seat selected-woman seat-pre""></div>
            <div class=""ms-3"">
                <p>Kad??n Dolu</p>
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
                <p>Bo?? Koltuk</p>
                <p>Al??nabilir</p>
            </div>
        </li>
    </ul>
</div>
<center>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "065e7ef9703aade740490ef25a14d85b6d179eec8040", async() => {
                WriteLiteral("\r\n        <div class=\"seat-row parent\">\r\n");
#nullable restore
#line 59 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                 for (int i = 1; i < 40; i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                     foreach (var item in Model.Ticket)
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
#line 75 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                         if (item.TicketGender == "Erkek")
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input class=\"seat selected-man child\"");
                BeginWriteAttribute("value", " value=\"", 2677, "\"", 2687, 1);
#nullable restore
#line 77 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
WriteAttributeValue("", 2685, j, 2685, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 78 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                        }
                                        else if (item.TicketGender == "Kad??n")
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input class=\"seat selected-woman child\"");
                BeginWriteAttribute("value", " value=\"", 2942, "\"", 2952, 1);
#nullable restore
#line 81 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
WriteAttributeValue("", 2950, j, 2950, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 82 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                         
                                        i++;
                                    }
                                }
                            }
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "065e7ef9703aade740490ef25a14d85b6d179eec11839", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                                                       WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 89 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TicketSeatNo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "065e7ef9703aade740490ef25a14d85b6d179eec14649", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 93 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TicketFromWhere);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "065e7ef9703aade740490ef25a14d85b6d179eec16396", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 94 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TicketToWhere);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "065e7ef9703aade740490ef25a14d85b6d179eec18141", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 95 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\GetTicketsFromRoute.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RouteId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TicketWithList> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
