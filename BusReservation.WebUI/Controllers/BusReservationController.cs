using BusReservation.Business.Abstract;
using BusReservation.Entity;
using BusReservation.WebUI.EmailServices;
using BusReservation.WebUI.Models;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Controllers
{
    public class BusReservationController : Controller
    {
        private IRouteService _routeService;
        private ITicketService _ticketService;
        private IEmailSender _emailSender;

        public BusReservationController(IRouteService routeService, ITicketService ticketService, IEmailSender emailSender)
        {
            _routeService = routeService;
            _ticketService = ticketService;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View(); 
        } 

        public IActionResult FindRoute(string cityFirst, string cityLast, DateTime goingDate)
        {
            if (cityFirst == cityLast)
            {
                ShowMessage("Başlangıç ve Bitiş Rotaları Aynı Olamaz", "danger");
                return Redirect("~/");

            }
            ViewBag.From = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cityFirst);
            ViewBag.ToWhere = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cityLast);
            return View(_routeService.FindRoute(cityFirst,cityLast,goingDate));
        }
        public IActionResult GetTicketsFromRoute(int id, string cityFirst, string cityLast)
        {
            var ticket = new TicketWithList()
            {
                TicketFromWhere = cityFirst,
                TicketToWhere = cityLast,
                RouteId = _routeService.GetRouteFromRouteId(id),
                Ticket = _ticketService.GetTicketsWithRoute(id)
            };
            return View(ticket);
        }
        public IActionResult GetPassangerInfo(TicketWithList ticket)
        {
            Random rnd = new Random();
            int pnr = rnd.Next(100000000, 900000000);
            string routeHour = _ticketService.GetHour(ticket.RouteId);
            string routeDate = _ticketService.GetDate(ticket.RouteId);
            double routePrice = _ticketService.GetPrice(ticket.RouteId);
            
            var newTicket = new Ticket()
            {
                RouteId = ticket.RouteId,
                TicketDate = routeDate,
                TicketPrice = routePrice,
                TicketClock = routeHour,
                TicketFromWhere = ticket.TicketFromWhere,
                TicketSeatNo = ticket.TicketSeatNo,
                TicketPnrNo = pnr.ToString(),
                TicketToWhere = ticket.TicketToWhere
            };
            return View(newTicket);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTicket(Ticket ticket)
        {
            var tickets = _ticketService.GetTicketsWithRoute(ticket.RouteId);
            if (ticket.TicketSeatNo % 3 == 2)
            {
                var ticketRight = tickets.Find(i => i.TicketSeatNo == ticket.TicketSeatNo + 1);
                if (ticketRight != null && ticketRight.TicketGender != ticket.TicketGender)
                {
                    ShowMessage("Yanyana olan koltuklar da aynı cinsiyet seçilmelidir", "danger");
                    return RedirectToAction("GetPassangerInfo",ticket);
                }
            }
            else if(ticket.TicketSeatNo % 3 == 0)
            {
                var ticketLeft = tickets.Find(i => i.TicketSeatNo == ticket.TicketSeatNo - 1);
                if (ticketLeft != null && ticketLeft.TicketGender != ticket.TicketGender)
                {
                    ShowMessage("Yanyana olan koltuklar da aynı cinsiyet seçilmelidir", "danger");
                    return RedirectToAction("GetPassangerInfo", ticket);
                }
            }
            string htmlMes = $"<h4>Sayın {ticket.TicketName} Rezervasyon Bilgileriniz Aşağıdadır.</h4>" +
                $"<h6>PNR No: = {ticket.TicketPnrNo}</h6>" +
                $"<h6>İsim = {ticket.TicketName}</h6>" +
                $"<h6>Soyisim = {ticket.TicketSurname}</h6>" +
                $"<h6>Nereden = {ticket.TicketFromWhere}</h6>" +
                $"<h6>Nereye = {ticket.TicketToWhere}</h6>" +
                $"<h6>Tarih = {ticket.TicketDate}</h6>" +
                $"<h6>Saat = {ticket.TicketClock}</h6>" +
                $"<h6>Koltuk No = {ticket.TicketSeatNo}</h6>";
            await _emailSender.SendEmailAsync(ticket.TicketMail, "Varlı Seyahat Rezervasyon Bilgileri", htmlMes);
            _ticketService.Create(ticket);
            return View(ticket);
        }
        private void ShowMessage(string message, string type)
        {
            var msg = new AlertMessage()
            {
                Message = message,
                Type = type
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
    }
}
