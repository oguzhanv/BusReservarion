#pragma checksum "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0fdfb4e6665fd487dcd456e61844416e2da7c7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BusReservation_SuccessTicket), @"mvc.1.0.view", @"/Views/BusReservation/SuccessTicket.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0fdfb4e6665fd487dcd456e61844416e2da7c7b", @"/Views/BusReservation/SuccessTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68777c9f1237a2539b6b54c76e3699e777332a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BusReservation_SuccessTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ticket>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4 class=\"mt-2 text-success text-center\">Sayın ");
#nullable restore
#line 2 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml"
                                           Write(Model.TicketName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Rezervasyon Bilgileriniz Aşağıdadır.</h4>
<div class=""tick-animation"">
    <div class=""trigger""></div>
    <svg version=""1.1"" id=""tick"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
         viewBox=""0 0 37 37"" style=""enable-background:new 0 0 37 37;"" xml:space=""preserve"">
<path class=""circ path"" style=""fill:none;stroke:#000;stroke-width:3;stroke-linejoin:round;stroke-miterlimit:10;"" d=""
	M30.5,6.5L30.5,6.5c6.6,6.6,6.6,17.4,0,24l0,0c-6.6,6.6-17.4,6.6-24,0l0,0c-6.6-6.6-6.6-17.4,0-24l0,0C13.1-0.2,23.9-0.2,30.5,6.5z"" />
<polyline class=""tick path"" style=""fill:none;stroke:#000;stroke-width:3;stroke-linejoin:round;stroke-miterlimit:10;"" points=""
	11.6,20 15.9,24.2 26.4,13.8 "" />
</svg>
</div>

<table class=""table table-bordered table-primary"">
    <thead>
        <tr class=""text-center"">
            <th scope=""col"">Ticket PNR No</th>
            <th scope=""col"">İsim</th>
            <th scope=""col"">Soyisim</th>
            <th scope=""col"">Cinsiyet<");
            WriteLiteral(@"/th>
            <th scope=""col"">Mail</th>
            <th scope=""col"">Nereden</th>
            <th scope=""col"">Nereye</th>
            <th scope=""col"">Koltuk No</th>
            <th scope=""col"">Tarih</th>
            <th scope=""col"">Saat</th>

        </tr>
    </thead>
    <tbody>
        <tr class=""text-center"">
            <td>");
#nullable restore
#line 32 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml"
           Write(Model.TicketPnrNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml"
           Write(Model.TicketName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml"
           Write(Model.TicketSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml"
           Write(Model.TicketGender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml"
           Write(Model.TicketMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml"
           Write(Model.TicketFromWhere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml"
           Write(Model.TicketToWhere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml"
           Write(Model.TicketSeatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml"
           Write(Model.TicketDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\oguzh\Desktop\Bus-Reservation\BusReservation.WebUI\Views\BusReservation\SuccessTicket.cshtml"
           Write(Model.TicketClock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n<h5 class=\"text-lg-right\">Rezervasyon bilgileriniz mail adresinize gönderilmiştir.</h5>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ticket> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591